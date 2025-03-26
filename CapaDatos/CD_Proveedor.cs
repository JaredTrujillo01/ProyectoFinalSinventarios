using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Proveedor
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarProvee()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * from Proveedor";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarProveedor(string nombre, string direccion, string telefono)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO Proveedor (Nombre, Direccion, Telefono) " +
                                  "VALUES (@nombre, @direccion, @telefono)";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void ActualizarProveedor(int id, string nombre, string direccion, string telefono)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UPDATE Proveedor SET Nombre = @nombre, Direccion = @direccion, Telefono = @telefono WHERE IdProveedor = @id";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void EliminarProveedor(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DELETE FROM Proveedor WHERE IdProveedor = @id";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public DataTable BuscarProveedor(string valor)
        {
            DataTable res = new DataTable();
            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "Select * From Proveedor Where Nombre LIKE '%' + @valor + '%'";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@valor", valor);

            SqlDataReader leer = comando.ExecuteReader();
            res.Load(leer);

            conexion.CerrarConexion();

            return res;

        }
    }

}
