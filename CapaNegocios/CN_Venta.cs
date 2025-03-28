using CapaDatos;
using System;
using System.Collections.Generic;

namespace CapaNegocios
{
    public class CN_Venta
    {
        private CD_Venta objetoCD = new CD_Venta();

        public int InsertarVenta(int idCliente, int idEmpleado, DateTime fechaVenta, decimal totalVenta, List<(int IdProducto, int Cantidad, decimal PrecioVenta)> detalleVentas)
        {
            objetoCD.InsertarVenta(idCliente, idEmpleado, fechaVenta, totalVenta);
            int idVenta = objetoCD.ObtenerUltimaVentaId();

            foreach (var detalle in detalleVentas)
            {
                objetoCD.InsertarDetalleVenta(idVenta, detalle.IdProducto, detalle.Cantidad, detalle.PrecioVenta);
            }

            return idVenta;
        }

        public List<Producto> ObtenerProductos()
        {
            return objetoCD.ObtenerProductosConProveedor();
        }

        public List<Cliente> ObtenerClientes()
        {
            return objetoCD.ObtenerClientes();
        }
        public bool ActualizarStock(int idProducto, int cantidad)
        {
            return objetoCD.ActualizarStock(idProducto, cantidad);
        }

        public Producto ObtenerProductoPorId(int idProducto)
        {
            return objetoCD.ObtenerProductoPorId(idProducto);
        }

    }
}
