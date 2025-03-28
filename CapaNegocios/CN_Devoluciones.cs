using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Devoluciones
    {
        private readonly CD_Devoluciones objDatos = new CD_Devoluciones();

        public DataTable ObtenerVentas()
        {
            return objDatos.ObtenerVentas();
        }
        public DataTable ObtenerProductosPorVenta(int idVenta)
        {
            return objDatos.ObtenerProductosPorVenta(idVenta);
        }
        public int ObtenerCantidadVendida(int idVenta, int idProducto)
        {
            return objDatos.ObtenerCantidadVendida(idVenta, idProducto);
        }

        public void RegistrarDevolucion(int idVenta, int idProducto, int cantidad, string motivo, string estado)
        {
            estado = (motivo == "Producto defectuoso" || motivo == "Mal estado") ? "No reintegrable" : "Reintegrado al stock";

            objDatos.RegistrarDevolucion(idVenta, idProducto, cantidad, motivo, estado);

            if (estado == "Reintegrado al stock")
            {
                objDatos.ActualizarStock(idProducto, cantidad);
            }
        }
    }
}
