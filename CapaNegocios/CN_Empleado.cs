using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class CN_Empleados
    {
        private CD_Empleados objetoCD = new CD_Empleados();

        public void AgregarEmpleado(string nombre, string apellido, string usuario, string password, string rol)
        {
            objetoCD.InsertarEmpleado(nombre, apellido, usuario, password, rol);
        }

        public DataTable MostrarEmpleados()
        {
            return objetoCD.MostrarEmpleados();
        }

        public DataTable BuscarEmpleado(string valor) 
        {
            return objetoCD.BuscarEmpleado(valor);
        }

        public void eliminarEmpleado(int id)
        {
            objetoCD.EliminarEmpleado(id);
        }
    }
}
