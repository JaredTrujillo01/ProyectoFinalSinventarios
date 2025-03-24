using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace CapaDatos
{
    public class CD_Login
    {
        private CD_Conexion conexion = new CD_Conexion();

        public DataTable ValidarUsuario(string usuario, string password)
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand("sp_ValidarUsuario", conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Usuario", usuario);
            comando.Parameters.AddWithValue("@Password", HashPassword(password));

            SqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }


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

        public bool CambiarPassword(string usuario, string passwordActual, string nuevoPassword)
        {
            using (SqlConnection con = conexion.AbrirConexion())
            {
                SqlCommand comando = new SqlCommand("sp_CambiarPassword", con);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@Usuario", SqlDbType.NVarChar, 50).Value = usuario;
                comando.Parameters.Add("@PasswordActual", SqlDbType.NVarChar, 64).Value = HashPassword(passwordActual);
                comando.Parameters.Add("@NuevoPassword", SqlDbType.NVarChar, 64).Value = HashPassword(nuevoPassword);

                int filasAfectadas = comando.ExecuteNonQuery(); 

                return filasAfectadas > 0; 
            }
        }
    }
}
