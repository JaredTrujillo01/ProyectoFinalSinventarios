using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
            this.Hide();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();
            proveedores.Show();
            this.Hide();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            Compras compras = new Compras();
            compras.Show();
            this.Hide();
        }

        private void btnCategorías_Click(object sender, EventArgs e)
        {
            Categorias categorias = new Categorias();
            categorias.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicioSesion salir = new InicioSesion();
            salir.Show();
            this.Hide();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Empleados emp = new Empleados();
            emp.Show();
            this.Hide(); 
        }
    }
}
