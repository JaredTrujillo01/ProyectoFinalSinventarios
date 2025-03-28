using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class DetalleVenta
    {
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public DetalleVenta(int idProducto, int cantidad, decimal precioVenta)
        {
            IdProducto = idProducto;
            Cantidad = cantidad;
            PrecioVenta = precioVenta;
        }
    }
}
