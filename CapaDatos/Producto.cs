using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Stock { get; set; }

        public Producto()
        {
        }
        public Producto(int idProducto, string nombre)
        {
            IdProducto = idProducto;
            Nombre = nombre;
        }
        public Producto(int idProducto, string nombre, decimal precioUnitario, int stock)
        {
            IdProducto = idProducto;
            Nombre = nombre;
            PrecioUnitario = precioUnitario;
            Stock = stock;
        }
    }
}
