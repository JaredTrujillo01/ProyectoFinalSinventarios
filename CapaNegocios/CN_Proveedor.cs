using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class CN_Proveedor
    {
        private CD_Proveedor objetoCD = new CD_Proveedor();
        public DataTable MostrarProvee()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarProvee();
            return tabla;
        }

        public void InsertarProveedor(string nombre, string direccion, string telefono)
        {
            objetoCD.InsertarProveedor(nombre, direccion, telefono);
        }

        public void ActualizarProveedor(int id, string nombre, string direccion, string telefono)
        {
            objetoCD.ActualizarProveedor(id, nombre, direccion, telefono);
        }

        public void EliminarProveedor(int id)
        {
            objetoCD.EliminarProveedor(id);
        }

        public DataTable BuscarProveedor(string valor)
        {
            return objetoCD.BuscarProveedor(valor);
        }
    }
}
