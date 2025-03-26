using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class CN_Cliente
    {
        private CD_Clientes objetoCD = new CD_Clientes();

        public DataTable MostrarCliente()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarCli();
            return tabla;
        }

        public void InsertarCliente(string nombre, string apellido, string dni, string correo, string telefono)
        {
            objetoCD.InsertarCliente(nombre, apellido, dni, correo, telefono);
        }

        public void ActualizarCliente(int id, string nombre, string apellido, string dni, string correo, string telefono)
        {
            objetoCD.ActualizarCliente(id, nombre, apellido, dni, correo, telefono);
        }

        public void EliminarCliente(int id)
        {
            objetoCD.EliminarCliente(id);
        }

        public DataTable Buscarclien(string valor)
        {
            return objetoCD.BuscarCliente(valor);
        }
    }
}
