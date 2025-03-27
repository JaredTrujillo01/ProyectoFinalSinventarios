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
using Microsoft.Identity.Client;


namespace CapaPresentacion.Formularios
{
    public partial class Clintes : Form
    {
        CN_Cliente objetoCN = new CN_Cliente();
        int Idcliente = 0;
        public Clintes()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MenuAdmin menuA = new MenuAdmin();
            menuA.Show();
            this.Hide();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            MenuVendedor menuA = new MenuVendedor();
            menuA.Show();
            this.Hide();
        }

        private void Clintes_Load(object sender, EventArgs e)
        {
            mostrarClientes();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void mostrarClientes()
        {
            CN_Cliente objeto = new CN_Cliente();
            dataGridView1.DataSource = objeto.MostrarCliente();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCN.InsertarCliente(
                    txtNombre.Text,
                    txtApellido.Text,
                    txtDNI.Text,
                    txtCorreo.Text,
                    txtTelefono.Text

                );
                MessageBox.Show("Cliente insertado correctamente");
                mostrarClientes();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el cliente: " + ex.Message);
            }

        }

        public void limpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Idcliente != 0)
            {
                objetoCN.EliminarCliente(Idcliente);
                MessageBox.Show("Cliente eliminado correctamente");
                mostrarClientes();
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Seleccione un cliente");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCN.ActualizarCliente(
                    Idcliente,
                    txtNombre.Text,
                    txtApellido.Text,
                    txtDNI.Text,
                    txtCorreo.Text,
                    txtTelefono.Text

                );
                MessageBox.Show("Cliente actualizado correctamente");
                mostrarClientes();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el cliente: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                Idcliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdCliente"].Value);
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                txtDNI.Text = dataGridView1.CurrentRow.Cells["DNI"].Value.ToString();
                txtCorreo.Text = dataGridView1.CurrentRow.Cells["Correo"].Value.ToString();
                txtTelefono.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
            }
        }

        private void Clintes_Load_1(object sender, EventArgs e)
        {
            mostrarClientes();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Trim() != "")
            {
                dataGridView1.DataSource = objetoCN.Buscarclien(txtBuscar.Text);
            }
            else
            {
                MessageBox.Show("Ingrese el DNI del cliente que desea buscar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objetoCN.Buscarclien(txtBuscar.Text);
        }
    }
}
