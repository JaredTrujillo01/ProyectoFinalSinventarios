using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace CapaDatos
{
    public class CD_Empleados
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();

        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2")); 
                }
                return builder.ToString();
            }
        }

        public void InsertarEmpleado(string nombre, string apellido, string usuario, string password, string rol)
        {
            try
            {
                SqlCommand comando = new SqlCommand("sp_RegistrarUsuario", conexion.AbrirConexion());
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Usuario", usuario);
                comando.Parameters.AddWithValue("@Password", HashPassword(password));
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Apellido", apellido);
                comando.Parameters.AddWithValue("@Rol", rol);

                comando.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                conexion.CerrarConexion();
                throw new Exception("Error al insertar empleado: " + ex.Message);
            }
        }

        public DataTable MostrarEmpleados()
        {
            DataTable tabla = new DataTable();
            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM Empleados", conexion.AbrirConexion());
                SqlDataReader leer = comando.ExecuteReader();
                tabla.Load(leer);
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                conexion.CerrarConexion();
                throw new Exception("Error al obtener empleados: " + ex.Message);
            }
            return tabla;
        }
    }
}
