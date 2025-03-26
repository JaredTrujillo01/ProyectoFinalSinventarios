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
        CN_Empleados CNObjeto = new CN_Empleados();
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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Trim() != "")
            {
                dataGridView1.DataSource = CNObjeto.BuscarEmpleado(txtBuscar.Text);
            }
            else
            {
                MessageBox.Show("Ingrese el usuario que desea buscar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CNObjeto.BuscarEmpleado(txtBuscar.Text);
        }
    }
}
