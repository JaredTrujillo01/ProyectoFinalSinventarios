using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class CN_Categoria
    {
        private CD_Categoria objetoCD = new CD_Categoria();

        public DataTable MostrarCategoria()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarCategoria();
            return tabla;
        }

        public void InsertarCategoria(string nombre)
        {
            objetoCD.InsertarCategoria(nombre);
        }

        public void EliminarCategoria(int id)
        {
            objetoCD.EliminarCategoria(id);
        }

        public DataTable BuscarCate(string valor)
        {
            return objetoCD.BuscarCategoria(valor);
        }
    }
}
