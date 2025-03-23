using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace CapaPresentacion.Formularios
{
    public partial class Productos : Form
    {
        CN_Producto objetoCN = new CN_Producto();
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            mostrarProductos();
        }

        private void mostrarProductos()
        {
           dataGridView1.DataSource = objetoCN.Mostrar();
        }
    }
}
