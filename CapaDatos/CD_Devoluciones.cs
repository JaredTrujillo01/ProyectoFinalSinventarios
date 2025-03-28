using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Devoluciones
    {
        private readonly CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();

        public DataTable ObtenerVentas()
        {
            DataTable dt = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            try
            {
                string query = @"
            SELECT v.IdVenta, 
                   CONCAT(v.IdVenta, ' - ', c.DNI, ' - ', c.Nombre, ' ', c.Apellido) AS ClienteInfo
            FROM Venta v
            INNER JOIN Cliente c ON v.ClienteID = c.IdCliente";

                SqlDataAdapter da = new SqlDataAdapter(query, comando.Connection);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las ventas: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion(); 
            }
            return dt;
        }

        public DataTable ObtenerProductosPorVenta(int idVenta)
        {
            DataTable dt = new DataTable();
            try
            {
                comando.Connection = conexion.AbrirConexion();
                string query = @"
                    SELECT p.IdProducto, p.Nombre, dv.Cantidad 
                    FROM DetalleVenta dv
                    INNER JOIN Producto p ON dv.ProductoID = p.IdProducto
                    WHERE dv.VentaID = @idVenta";
                SqlDataAdapter da = new SqlDataAdapter(query, comando.Connection);
                da.SelectCommand.Parameters.AddWithValue("@idVenta", idVenta);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los productos por venta: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return dt;
        }

        public int ObtenerCantidadVendida(int idVenta, int idProducto)
        {
            int cantidadVendida = 0;
            try
            {
                comando.Connection = conexion.AbrirConexion();
                string query = @"
                    SELECT Cantidad FROM DetalleVenta 
                    WHERE VentaID = @idVenta AND ProductoID = @idProducto";
                SqlCommand cmd = new SqlCommand(query, comando.Connection);
                cmd.Parameters.AddWithValue("@idVenta", idVenta);
                cmd.Parameters.AddWithValue("@idProducto", idProducto);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    cantidadVendida = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la cantidad vendida: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return cantidadVendida;
        }

        public void RegistrarDevolucion(int idVenta, int idProducto, int cantidad, string motivo, string estado)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                string query = @"
                    INSERT INTO Devolucion (IdVenta, IdProducto, Cantidad, Motivo, Estado)
                    VALUES (@idVenta, @idProducto, @cantidad, @motivo, @estado)";
                SqlCommand cmd = new SqlCommand(query, comando.Connection);
                cmd.Parameters.AddWithValue("@idVenta", idVenta);
                cmd.Parameters.AddWithValue("@idProducto", idProducto);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@motivo", motivo);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar la devolución: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public void ActualizarStock(int idProducto, int cantidad)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                string query = @"
                    UPDATE Producto SET Stock = Stock + @cantidad WHERE IdProducto = @idProducto";
                SqlCommand cmd = new SqlCommand(query, comando.Connection);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@idProducto", idProducto);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el stock: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}
