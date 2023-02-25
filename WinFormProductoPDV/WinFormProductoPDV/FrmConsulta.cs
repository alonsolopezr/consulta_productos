using MySql.Data.MySqlClient;
using System.Runtime.Intrinsics.Arm;

namespace WinFormProductoPDV
{
    public partial class FrmConsulta : Form
    {
        //MysqlObjects
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=productos_pdv;Uid=root;Pwd=;");
        MySqlCommand comando;
        //el obj para recibir datos de SELECT
        MySqlDataReader dr;
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconPicBoxBuscar_Click(object sender, EventArgs e)
        {
            //conectamos a la BD
            con.Open();

            //definir el comando SELECT
            comando = new MySqlCommand("SELECT * FROM productos WHERE nombre='" + txtBuscador.Text + "'");
            //ejecutamos el comando y guardamos el RESULTADO
            //asignamos la con al commando
            comando.Connection= con;

            //comando.ExecuteNonQuery(); //para ejecutar INSERT, DELETE, UPDATE
            //comando.ExecuteScalar(); //para ejecutar SELECT con un solo campo 
            dr = comando.ExecuteReader(); //para recibir muchos Registros

            //pasamos el resultado al DataGrid
            if (dr.HasRows)
            {
                //pasamos cada renglon al DTGRID
                while (dr.Read())
                {
                    //id - nombre - descripcion - codigo_barras - precio - imagen
                    //0     1      2               3              4          5
                    var myString = dr.GetString(0); //The 0 stands for "the 0'th column", so the first column of the result.
                    dGridProductos.Rows.Add(new object[] {dr.GetInt16(0),
                                                          dr.GetString(1),
                                                          dr.GetString(2),
                                                          dr.GetString(3),
                                                          dr.GetDouble(4),
                                                          dr.GetString(5),
                                                          });
                }
            }
            else {
                MessageBox.Show("No hay registros que cumplan con tu búsqueda ");
            }

            //cerrar la conexion
            con.Close();
        }
    }
}