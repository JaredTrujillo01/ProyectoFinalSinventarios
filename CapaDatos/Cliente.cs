using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public Cliente()
        {
        }

        public Cliente(int idCliente, string dNI, string nombre, string apellido)
        {
            IdCliente = idCliente;
            DNI = dNI;
            Nombre = nombre;
            Apellido = apellido;
        }


        public Cliente(int idCliente, string nombre, string apellido, string dni, string correo, string telefono)
        {
            IdCliente = idCliente;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Correo = correo;
            Telefono = telefono;
        }
    }
}
