using MySql.Data.MySqlClient;
using System.Runtime.Intrinsics.Arm;

namespace WinFormProductoPDV
{
    public partial class FrmCRUD : Form
    {
        //MysqlObjects
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=productos_pdv;Uid=root;Pwd=;");
        MySqlCommand comando;
        //el obj para recibir datos de SELECT
        MySqlDataReader dr;
        //guardar el id al darle click en el DataGrid
        int id = 0;

        public FrmCRUD()
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

        private void FrmCRUD_Load(object sender, EventArgs e)
        {
            this.cargarDatosADataGrid();
        }

        private void iconPicBoxNuevo_Click(object sender, EventArgs e)
        {
            //si estan deshabilitados los txts, habilitarlos
            if (txtNombre.Enabled == false &&
                txtDescripcion.Enabled == false &&
                txtCodBarras.Enabled == false &&
                txtPrecio.Enabled == false &&
                txtImagen.Enabled == false)
            {
                //habilitamos y limpiamos los texts
                this.limpiarForm(true);
            }
        }

        private void iconPicBoxSave_Click(object sender, EventArgs e)
        {
            //validar los datos de cada textBox, antes de guardar
            //guardar

            //1- conectarse
            con.Open();
            //2- crear command de insert
            comando = new MySqlCommand("INSERT INTO productos (nombre, descripcion, codigo_barras, precio,imagen) " +
                                                       "VALUES('" + txtNombre.Text + "','" + txtDescripcion.Text + "','" + txtCodBarras.Text + "'," + txtPrecio.Text + ",'" + txtImagen.Text + "' )");
            //2.1 Ponerle la conexion al COMMAND
            comando.Connection = con;
            //3- EJECUTAR el insert (executeNonQuery())
            int res = comando.ExecuteNonQuery();
            //4- Validar que haya sido ejecutaDO CORRECTAMENTE
            if (res == 1)
            {
                //msg OK
                MessageBox.Show("Producto creado OK!");
                //validar que el picbox tenga imagen
                if (picBoxImagen.Image != null) {
                   

                    //guardar la imagen en la carpeta de imagenes de producto
                    picBoxImagen.Image.Save("..\\..\\..\\imagenes\\" + txtImagen.Text);
                }
              
            }
            else
            {
                //msg OK
                MessageBox.Show("ERROR, Producto no creado!");
            }
            //5- cerrar CONEXION
            con.Close();
            //vamos a limpiar los texto y deshabilitarlos
            this.limpiarForm(false);
            //Recargamos el fform
            this.FrmCRUD_Load(sender, e);
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
                txtDescripcion.Enabled = true;
                txtDescripcion.Clear();
                txtCodBarras.Enabled = true;
                txtCodBarras.Clear();
                txtPrecio.Enabled = true;
                txtPrecio.Clear();
                txtImagen.Enabled = true;
                txtImagen.Clear();
            }
            else {
                //habilitamos y limpiamos los texts
                txtNombre.Enabled = false;
                txtNombre.Clear();
                txtNombre.Text = "";
                txtDescripcion.Enabled = false;
                txtDescripcion.Clear();
                txtCodBarras.Enabled = false;
                txtCodBarras.Clear();
                txtPrecio.Enabled = false;
                txtPrecio.Clear();
                txtImagen.Enabled = false;
                txtImagen.Clear();
            }
        }

        public void cargarDatosADataGrid() {
            //consultamos la BD para poner los registros actuales de productos
            //1.conectarse
            con.Open();
            //2. crear el command (SELECT *)
            comando = new MySqlCommand("SELECT * FROM productos ORDER BY nombre ASC");
            //3. asociar la CONEXION al COMMAND
            comando.Connection = con;
            //4. ejecutar el COMMAND (dataReader = executeReader())
            dr = comando.ExecuteReader();
            //5. Mostrarlos en el GridView
            if (dr.HasRows)
            {
                dGridProductos.Rows.Clear();
                //leer y mostrar DataGrid
                while (dr.Read())
                {
                    //mostrar cada campo dentro un RENGLON del GridView
                    dGridProductos.Rows.Add(
                            dr.GetInt32("id"),
                            dr.GetString("nombre"),
                            dr.GetString("codigo_barras"),
                            dr.GetString("descripcion"),
                            dr.GetDouble("precio"),
                            dr.GetString("imagen")
                        );
                }

            }
            else
            {
                MessageBox.Show("No hay productos registrados aún...");
            }
            //6. cerrar conexion TE DIJE!!!!
            con.Close();
        }

        private void iconPicBoxOpenImage_Click(object sender, EventArgs e)
        {
            //abrir el OpenFiledialog
            DialogResult res = openDialogProdImagen.ShowDialog();
            //cargar archivo en el picBox
            if (res == DialogResult.OK)
            {
                picBoxImagen.Image = new Bitmap(openDialogProdImagen.FileName);
                //crear nombre unico de arch de imagen
                DateTime dtNombre = DateTime.Now;
                string nombreImg = "prod_" + dtNombre.Ticks + ".png";
                txtImagen.Text = nombreImg;
            }
            else
            {

            }
        }

        private void dGridProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //cargar los datos  al form
            
            this.id = int.Parse(dGridProductos.Rows[e.RowIndex].Cells[0].Value.ToString()); //id
            txtNombre.Text = dGridProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
         
            txtCodBarras.Text  = dGridProductos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDescripcion.Text = dGridProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPrecio.Text = dGridProductos.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtImagen.Text = dGridProductos.Rows[e.RowIndex].Cells[5].Value.ToString();
            //tambien la imagen del picBox
            picBoxImagen.ImageLocation = "..\\..\\..\\imagenes\\"+txtImagen.Text;
        }

        private void picBoxImagen_Click(object sender, EventArgs e)
        {

        }

        private void dGridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}