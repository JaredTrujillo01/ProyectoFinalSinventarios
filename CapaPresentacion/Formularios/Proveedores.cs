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
using System.Runtime.InteropServices;

namespace CapaPresentacion.Formularios
{
    public partial class Proveedores : Form
    {
        CN_Proveedor objetoCN = new CN_Proveedor();
        int proveedorId = 0;
        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            mostrarProveedor();
        }
        private void mostrarProveedor()
        {
            CN_Proveedor objeto = new CN_Proveedor();
            dataGridView1.DataSource = objeto.MostrarProvee();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCN.InsertarProveedor(
                    txtNombre.Text,
                    txtDireccion.Text,
                    txtTelefono.Text
                );
                MessageBox.Show("Proveedor insertado correctamente");
                mostrarProveedor();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el proveedor: " + ex.Message);
            }
        }
        private void limpiarCampos()
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCN.ActualizarProveedor(
                    proveedorId,
                    txtNombre.Text,
                    txtDireccion.Text,
                    txtTelefono.Text
                );
                MessageBox.Show("Proveedor actualizado correctamente");
                mostrarProveedor();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el proveedor: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                proveedorId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdProveedor"].Value);
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDireccion.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
                txtTelefono.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (proveedorId != 0)
            {
                try
                {
                    objetoCN.EliminarProveedor(proveedorId);
                    MessageBox.Show("Proveedor eliminado correctamente");
                    mostrarProveedor();
                    limpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el proveedor: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MenuAdmin menuA = new MenuAdmin();
            menuA.Show();
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Trim() != "")
            {
                dataGridView1.DataSource = objetoCN.BuscarProveedor(txtBuscar.Text);
            }
            else
            {
                MessageBox.Show("Ingrese el Nombre del proveedor que desea buscar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objetoCN.BuscarProveedor(txtBuscar.Text);
        }
    }
}
