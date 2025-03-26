using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Clientes
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarCli()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * from Cliente";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarCliente(string nombre, string apellido, string dni, string correo, string telefono)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO Cliente (Nombre, Apellido, DNI,Correo, Telefono) " +
                                  "VALUES (@nombre, @apellido, @dni, @correo, @telefono)";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@dni", dni);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void ActualizarCliente(int id, string nombre, string apellido, string dni, string correo, string telefono)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UPDATE Cliente SET Nombre = @nombre, Apellido = @apellido, DNI = @dni, Correo = @correo, Telefono = @telefono WHERE IdCliente = @id";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@dni", dni);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void EliminarCliente(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DELETE FROM Cliente WHERE IdCliente = @id";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public DataTable BuscarCliente(string valor)
        {
            DataTable dt = new DataTable();
            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "Select * From Cliente Where DNI LIKE '%' + @valor + '%'";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@valor", valor);

            SqlDataReader leer = comando.ExecuteReader();
            dt.Load(leer);

            conexion.CerrarConexion();
            return dt;

        }
    }
}
