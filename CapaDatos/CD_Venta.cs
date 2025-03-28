using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Venta
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();

        public void InsertarVenta(int idCliente, int idEmpleado, DateTime fechaVenta, decimal totalVenta)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO Venta (ClienteID, EmpleadoID, FechaVenta, TotalVenta) " +
                                  "VALUES (@idCliente, @idEmpleado, @fechaVenta, @totalVenta)";

            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idCliente", idCliente);
            comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            comando.Parameters.AddWithValue("@fechaVenta", fechaVenta);
            comando.Parameters.AddWithValue("@totalVenta", totalVenta);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public int ObtenerUltimaVentaId()
        {
            int idVenta = 0;
            string query = "SELECT MAX(IdVenta) FROM Venta";

            using (SqlCommand command = new SqlCommand(query, conexion.AbrirConexion()))
            {
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    idVenta = Convert.ToInt32(result);
                }
            }

            conexion.CerrarConexion();
            return idVenta;
        }

        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            comando.Connection = conexion.AbrirConexion(); 
            comando.CommandText = "SELECT IdCliente, DNI, Nombre, Apellido FROM Cliente";

            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Cliente cliente = new Cliente
                {
                    IdCliente = Convert.ToInt32(reader["IdCliente"]),
                    DNI = reader["DNI"].ToString(),
                    Nombre = reader["Nombre"].ToString(),
                    Apellido = reader["Apellido"].ToString()
                };

                clientes.Add(cliente);
            }

            conexion.CerrarConexion();

            return clientes;
        }
        public List<Producto> ObtenerProductosConProveedor()
        {
            List<Producto> productos = new List<Producto>();

            comando.Connection = conexion.AbrirConexion(); 
            comando.CommandText = "SELECT P.IdProducto, P.Nombre AS Producto, PR.Nombre AS Proveedor, P.PrecioUnitario " +
                                 "FROM Producto P JOIN Proveedor PR ON P.ProveedorID = PR.IdProveedor"; 

            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Producto producto = new Producto
                {
                    IdProducto = Convert.ToInt32(reader["IdProducto"]),
                    Nombre = reader["Producto"].ToString(),
                    ProveedorNombre = reader["Proveedor"].ToString(),  
                    PrecioUnitario = Convert.ToDecimal(reader["PrecioUnitario"])
                };

                productos.Add(producto);
            }

            conexion.CerrarConexion();

            return productos;
        }


        public void InsertarDetalleVenta(int idVenta, int idProducto, int cantidad, decimal precioVenta)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO DetalleVenta (VentaID, ProductoID, Cantidad, PrecioVenta) " +
                                  "VALUES (@idVenta, @idProducto, @cantidad, @precioVenta)";

            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idVenta", idVenta);
            comando.Parameters.AddWithValue("@idProducto", idProducto);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@precioVenta", precioVenta);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public Producto ObtenerProductoPorId(int idProducto)
        {
            Producto producto = null;

            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SELECT IdProducto, Nombre, Stock, PrecioUnitario FROM Producto WHERE IdProducto = @idProducto";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idProducto", idProducto);

                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    producto = new Producto
                    {
                        IdProducto = Convert.ToInt32(reader["IdProducto"]),
                        Nombre = reader["Nombre"].ToString(),
                        Stock = Convert.ToInt32(reader["Stock"]),
                        PrecioUnitario = Convert.ToDecimal(reader["PrecioUnitario"])
                    };
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el producto: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return producto;
        }


        public bool ActualizarStock(int idProducto, int cantidad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UPDATE Producto SET Stock = Stock - @cantidad WHERE IdProducto = @idProducto";

            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@idProducto", idProducto);

            int filasAfectadas = comando.ExecuteNonQuery();
            conexion.CerrarConexion();

            return filasAfectadas > 0; 
        }
    }
}
