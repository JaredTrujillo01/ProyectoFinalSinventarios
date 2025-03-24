using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using CapaDatos;

namespace CapaNegocios
{
    public class CN_Login
    {
        private CD_Login objetoCD = new CD_Login();

        public bool IniciarSesion(string usuario, string password, out string nombreCompleto, out string rol)
        {
            DataTable resultado = objetoCD.ValidarUsuario(usuario, password);

            if (resultado.Rows.Count > 0)
            {
                nombreCompleto = resultado.Rows[0]["Nombre"].ToString() + " " + resultado.Rows[0]["Apellido"].ToString();
                rol = resultado.Rows[0]["Rol"].ToString();
                return true;
            }
            else
            {
                nombreCompleto = "";
                rol = "";
                return false;
            }
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
            return objetoCD.CambiarPassword(usuario, passwordActual, nuevoPassword);
        }
    }
}
