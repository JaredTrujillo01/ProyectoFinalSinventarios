using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Categoria
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarCategoria()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * from Categoria";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarCategoria(string nombre)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO Categoria (Nombre) " +
                                  "VALUES (@nombre)";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void EliminarCategoria(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DELETE FROM Categoria WHERE IdCategoria = @id";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public DataTable BuscarCategoria(string valor)
        {
            DataTable dt = new DataTable();
            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "Select * from Categoria Where Nombre LIKE '%' + @valor + '%'";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@valor", valor);
            SqlDataReader leer = comando.ExecuteReader();
            dt.Load(leer);

            conexion.CerrarConexion();
            return dt;
        }
    }
}
