using FontAwesome.Sharp;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProductoPDV
{
    public partial class FrmUsuarios : Form
    {
        int id = 0;
        //vars de BD
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=productos_pdv;Uid=root;Pwd=;");
        MySqlCommand comando = new MySqlCommand("SELECT * FROM usuarios");
        MySqlDataReader dr;

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void iconPicBoxNuevo_Click(object sender, EventArgs e)
        {
            //si estan deshabilitados los txts, habilitarlos
            if (txtNombre.Enabled == false &&
                txtCorreo.Enabled == false &&
                txtPassword.Enabled == false &&
                txtConfirmaContra.Enabled == false &&
                txtImagen.Enabled == false)
            {
                //habilitamos y limpiamos los texts
                this.limpiarForm(true);
            }

        }



        //método para limpiar form
        public void limpiarForm(bool habilita)
        {
            if (habilita)
            {
                //habilitamos y limpiamos los texts
                txtNombre.Enabled = true;
                txtNombre.Clear();
                txtNombre.Text = "";
                txtCorreo.Enabled = true;
                txtCorreo.Clear();
                txtPassword.Enabled = true;
                txtPassword.Clear();
                txtConfirmaContra.Enabled = true;
                txtConfirmaContra.Clear();
                txtImagen.Enabled = true;
                txtImagen.Clear();
            }
            else
            {
                //habilitamos y limpiamos los texts
                txtNombre.Enabled = false;
                txtNombre.Clear();
                txtNombre.Text = "";
                txtCorreo.Enabled = false;
                txtCorreo.Clear();
                txtPassword.Enabled = false;
                txtPassword.Clear();
                txtConfirmaContra.Enabled = false;
                txtConfirmaContra.Clear();
                txtImagen.Enabled = false;
                txtImagen.Clear();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            this.cargarDatosDeBD();
        }

        private void iconPicBoxSave_Click(object sender, EventArgs e)
        {
            //vamos a guardar un usuario
            //Vamos a validar LAS CONTRASEÑAS
            if (txtPassword.Text == txtConfirmaContra.Text)
            {
                try
                {
                    //intenta ejecutar estas lineas en orden

                    //abrir la conexion
                    con.Open();
                    //comando
                    comando = new MySqlCommand("INSERT INTO usuarios (nombre, correo, password, foto) "
                                               + $" VALUES('{txtNombre.Text}','{txtCorreo.Text}','{txtPassword.Text}','{txtImagen.Text}')");
                    //relacionar la conexion con el command
                    comando.Connection = con;

                    //EJECUTAR EL QUERY
                    int resultado = comando.ExecuteNonQuery();

                    if (resultado == 1)
                    {
                        MessageBox.Show("Registro guardado con ÉXITO");
                        //cargar los datos
                        this.cargarDatosDeBD();

                    }
                    else
                    {
                        MessageBox.Show("ERROR AL GRABAR  -Registro de usuario-");
                    }


                }

                catch (InvalidOperationException ioe)
                {
                    MessageBox.Show("Error de conexion con la BD. " + ioe.Message);
                }
                catch (MySqlException mex)
                {
                    MessageBox.Show("Error al conectarse a la BD. " + mex.Message);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar..." + ex.Message);

                }
                finally
                {
                    con.Close();
                }
            }
        }
        //metodo para cargar los datos de la BD
        public void cargarDatosDeBD()
        {
            //consultamos la BD para poner los registros actuales de
             if(con.State==ConnectionState.Closed)//1.conectarse

                con.Open();
            //2. crear el command (SELECT *)
            comando = new MySqlCommand("SELECT * FROM usuarios ORDER BY nombre ASC");
            //3. asociar la CONEXION al COMMAND
            comando.Connection = con;
            //4. ejecutar el COMMAND (dataReader = executeReader())
            dr = comando.ExecuteReader();
            //5. Mostrarlos en el GridView
            if (dr.HasRows)
            {
                dGridUsuarios.Rows.Clear();
                //leer y mostrar DataGrid
                while (dr.Read())
                {
                    //mostrar cada campo dentro un RENGLON del GridView
                    dGridUsuarios.Rows.Add(
                            dr.GetInt32("id"),
                            dr.GetString("nombre"),
                            dr.GetString(""),
                            dr.GetString(2),
                            dr.GetString(4)
                        );
                }

            }
            else
            {
                MessageBox.Show("No hay USUARIOS registrados aún...");
            }
            //6. cerrar conexion TE DIJE!!!!
            con.Close();
        }

        private void dGridUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //cada vez que se de click en una celda
            //pasar todos los datos al form
            txtNombre.Text = dGridUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCorreo.Text = dGridUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPassword.Text = dGridUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtImagen.Text = dGridUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString();
            //id del registro
            this.id = int.Parse(dGridUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void iconPicBoxDelete_Click(object sender, EventArgs e)
        {
            //borrar registro con el ID seleccion
            con.Open();
            //commando
            comando =  new MySqlCommand("DELETE FROM usuarios WHERE id="+this.id);
            //Connextion
            comando.Connection = con;
            //execute
            int res = comando.ExecuteNonQuery();

            if (res == 1) {
                MessageBox.Show("Ya se borro ya nos vamos...");
                this.limpiarForm(false);
                this.cargarDatosDeBD();
            }
            else
            {
                MessageBox.Show("ERROR LO CHECAMOS EL LUNES!!!");
            }
            con.Close();
        }

     
    }
}