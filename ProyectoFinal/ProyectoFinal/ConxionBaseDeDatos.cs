using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace ProyectoFinal
{
    class ConexionBaseDeDatos : IDisposable
    {    //objeto de la conexion sql
        SqlConnection cnx;

        //Metodo para poder obtner la conexion
        public ConexionBaseDeDatos()
        {
            try
            {
                cnx = new SqlConnection("Data Source=DESKTOP-PQBRDPK\\SQLEXPRESS;Initial Catalog=Usuarios;Integrated Security=True;");
                cnx.Open();

                MessageBox.Show("Se conectó correctamente", "Exito al conectar", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error inesperado", MessageBoxButtons.OK);
                throw; 
            }
        }

        public SqlConnection ObtenerConexion()
        {    //devuelve el objeto de la conexion
            return cnx;
        }

        public void Dispose()
        {
            if (cnx != null)
            {   //aqui se libera la conexion si es nula
                cnx.Close();
                cnx.Dispose();
            }
        }
    }
}
