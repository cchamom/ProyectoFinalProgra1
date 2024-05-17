using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }
        //este es un metodo creado para ejecuatarse cuando hagas click al boton y te va a registrar
        private void btn_Registrarse_Click(object sender, EventArgs e)
        {
            //los txt de los datos que deben de llenar los usuarios 
            string nombre = txt_Nombre_Registro.Text;
            string usuario = txt_Usuario_Registro.Text;
            string Tipo_Empleado = txt_Tipo_Empleado.Text;
            string contraseña = txt_Contraseña_Registro.Text;

            //aqui establecemos una conexion a la base de datos y utilizamos la clase ConexionBaseDeDatos
            using (ConexionBaseDeDatos conexion = new ConexionBaseDeDatos())
            {
                SqlConnection cnx = conexion.ObtenerConexion();
                //se define la consulta de Sql para poder ingresar un nuevo usuario en la tabal Usuarios de la BD
                string query = "INSERT INTO Usuarios (Nombre, Usuario, Contraseña, Tipo_Usuario) VALUES (@Nombre, @Usuario, @Contraseña, @TipoUsuario)";
                SqlCommand command = new SqlCommand(query, cnx);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Usuario", usuario);
                command.Parameters.AddWithValue("@Contraseña", contraseña);
                command.Parameters.AddWithValue("@TipoUsuario", Tipo_Empleado);
                //con el try y el catch ejecutamos la consulta y se agrega un nuevo usuario a la base de datos
                try
                {  
                    command.ExecuteNonQuery();
                    MessageBox.Show("Usuario registrado correctamente.");
                } 
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Id.Text = " ";
            txt_Contraseña_Registro.Text = " ";
            txt_Nombre_Registro.Text = " ";
            txt_Tipo_Empleado.Text = " ";
            txt_Usuario_Registro.Text = " ";

        }
    }
}
