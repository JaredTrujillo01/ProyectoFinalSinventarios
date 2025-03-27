using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class DetalleCompra
    {
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioCompra { get; set; }
        public DetalleCompra(int idProducto, int cantidad, decimal precioCompra)
        {
            IdProducto = idProducto;
            Cantidad = cantidad;
            PrecioCompra = precioCompra;
        }
    }
}
