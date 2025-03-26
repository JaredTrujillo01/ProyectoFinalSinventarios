using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocios
{
    public class CN_Producto
    {
        private CD_Productos objetoCD = new CD_Productos();
        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarProducto(string nombre, string descripcion, decimal precioUnitario, int stock, int idProveedor, int idCategoria)
        {
            objetoCD.Insertar(nombre, descripcion, precioUnitario, stock, idCategoria, idProveedor);
        }

        public void ActualizarProducto(int id, string nombre, string descripcion, decimal precio, int stock, int idProveedor, int idCategoria)
        {
            objetoCD.ActualizarProducto(id, nombre, descripcion, precio, stock, idProveedor, idCategoria);
        }

        public void EliminarProducto(int id)
        {
            objetoCD.EliminarProducto(id);
        }

        public DataTable BuscarProducto(string valor)
        {
           return objetoCD.BuscarProducto(valor);
        }
    }
}
