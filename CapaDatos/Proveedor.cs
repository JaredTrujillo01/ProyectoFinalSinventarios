using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Proveedor()
        {
        }

        public Proveedor(int idProveedor, string nombre)
        {
            IdProveedor = idProveedor;
            Nombre = nombre;
        }

        public Proveedor(int idProveedor, string nombre, string direccion, string telefono)
        {
            IdProveedor = idProveedor;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
        }
    }
}
