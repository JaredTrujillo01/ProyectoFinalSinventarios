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
    public partial class MenuVendedor : Form
    {
        public MenuVendedor()
        {
            InitializeComponent();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.Show();
            this.Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clintes clientes = new Clintes();
            clientes.Show();
            this.Hide();
        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            Devoluciones devoluciones = new Devoluciones();
            devoluciones.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicioSesion salir = new InicioSesion();
            salir.Show();
            this.Hide();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
            this.Hide();
        }
    }
}
