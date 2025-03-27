using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Productos
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar()
        {
           comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * from Producto";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void Insertar(string nombre, string descripcion, decimal precioUnitario, int stock, int idProveedor, int idCategoria)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO Producto (Nombre, Descripcion, PrecioUnitario, Stock, ProveedorID, CategoriaID ) " +
                                  "VALUES (@nombre, @descripcion, @precioUnitario, @stock, @idProveedor, @idCategoria)";

            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@precioUnitario", precioUnitario);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@idProveedor", idProveedor);
            comando.Parameters.AddWithValue("@idCategoria", idCategoria);

            comando.ExecuteNonQuery(); 
            conexion.CerrarConexion();
        }
        public void ActualizarProducto(int id, string nombre, string descripcion, decimal precio, int stock, int idProveedor, int idCategoria)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UPDATE Producto SET Nombre = @nombre, Descripcion = @descripcion, PrecioUnitario = @precio, Stock = @stock, ProveedorID = @idProveedor, CategoriaID = @idCategoria WHERE IdProducto = @id";

            comando.Parameters.Clear();

            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@idProveedor", idProveedor);
            comando.Parameters.AddWithValue("@idCategoria", idCategoria);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void EliminarProducto(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DELETE FROM Producto WHERE IdProducto = @id";

            comando.Parameters.Clear();

            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public DataTable BuscarProducto(string valor)
        {
            DataTable tablaResultado = new DataTable();
            comando.Connection = conexion.AbrirConexion();
  
            comando.CommandText = "SELECT * FROM Producto WHERE Nombre LIKE '%' + @valor + '%'";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@valor", valor);

            SqlDataReader leer = comando.ExecuteReader();
            tablaResultado.Load(leer);

            conexion.CerrarConexion();
            return tablaResultado;
        }

    }
}
