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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MenuAdmin menuA = new MenuAdmin();
            menuA.Show();
            this.Hide();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            mostrarEmpleados();
        }

        public void mostrarEmpleados()
        {
            CN_Empleados objeto = new CN_Empleados();
            dataGridView1.DataSource = objeto.MostrarEmpleados();
        }
    }
}
