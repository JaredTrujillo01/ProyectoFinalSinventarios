using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Compra
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();

        public void InsertarCompra(int idEmpleado, int idProveedor, DateTime fechaCompra, decimal totalCompra)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO Compra (IdEmpleado, IdProveedor, FechaCompra, TotalCompra) " +
                                  "VALUES (@idEmpleado, @idProveedor, @fechaCompra, @totalCompra)";

            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            comando.Parameters.AddWithValue("@idProveedor", idProveedor);
            comando.Parameters.AddWithValue("@fechaCompra", fechaCompra);
            comando.Parameters.AddWithValue("@totalCompra", totalCompra);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM Producto";

            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                productos.Add(new Producto(
                    Convert.ToInt32(reader["IdProducto"]),
                    reader["Nombre"].ToString(),
                    Convert.ToDecimal(reader["PrecioUnitario"])
                ));
            }

            conexion.CerrarConexion();
            return productos;
        }

        public List<Proveedor> ObtenerProveedores()
        {
            List<Proveedor> proveedores = new List<Proveedor>();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM Proveedor";

            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                proveedores.Add(new Proveedor(
                    Convert.ToInt32(reader["IdProveedor"]),
                    reader["Nombre"].ToString()
                ));
            }

            conexion.CerrarConexion();
            return proveedores;
        }

        public void ActualizarStock(int idProducto, int cantidad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UPDATE Producto SET Stock = Stock + @cantidad WHERE IdProducto = @idProducto";

            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@idProducto", idProducto);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
        public int ObtenerUltimaCompraId()
        {
            int idCompra = 0;
            string query = "SELECT MAX(IdCompra) FROM Compra";

            using (SqlCommand command = new SqlCommand(query, conexion.AbrirConexion()))
            {
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    idCompra = Convert.ToInt32(result);
                }
            }

            conexion.CerrarConexion();
            return idCompra;
        }


        public void InsertarDetalleCompra(int idCompra, int idProducto, int cantidad, decimal precioCompra)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO DetalleCompra (IdCompra, IdProducto, Cantidad, PrecioCompra) " +
                                  "VALUES (@idCompra, @idProducto, @cantidad, @precioCompra)";

            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idCompra", idCompra);
            comando.Parameters.AddWithValue("@idProducto", idProducto);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@precioCompra", precioCompra);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

    }
}
