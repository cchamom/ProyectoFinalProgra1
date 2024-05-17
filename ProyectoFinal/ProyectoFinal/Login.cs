using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace ProyectoFinal
{ 
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        //para que el usuario pueda iniciar sesion es un metodo que accede a la pagina principal cuando el usuario hace click al booton
        private void btn_Acceder_Click(object sender, EventArgs e)
        {
            //variables para obtener los datos de usuario y ciontraseña de loss txt
            string usuario = txt_Usuario.Text;
            string contraseña = txt_Contraseña.Text;


            //esta parte la usamos para acceder al sql y encontrar cuantos usuarios y contraseñas que coinciden con las que se ingresan
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PQBRDPK\\SQLEXPRESS;Initial Catalog=Usuarios;Integrated Security=True;"))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario AND Contraseña = @Contraseña";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Usuario", usuario);
                command.Parameters.AddWithValue("@Contraseña", contraseña);
                int count = (int)command.ExecuteScalar();//se ejecuta y obtenemos el usuario y la contraseña que coinciden y esten en la base de datos
                
                //etse if es para vereficarar si se enciontro el usuario y la contraseña y si no muetsra un mensaaje
                if (count > 0)
                {
                    MessageBox.Show("Inicio de sesión exitoso.");
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
                }
            }


            }
        //para poder limpiar los campos de texto
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Usuario.Text = " ";
            txt_Contraseña.Text = " ";

        } 
        //para cerrar la ventana
        private void btn_X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        //btn que perimite acceder al registro de usuarios si no te encuentras registrado aun en la BD
        private void btn_Registro_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
          
        }
    }
}
