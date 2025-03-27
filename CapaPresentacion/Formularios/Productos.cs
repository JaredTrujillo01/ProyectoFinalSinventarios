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
        int idProducto = 0;
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
            CN_Producto objeto = new CN_Producto();
            dataGridView1.DataSource = objeto.Mostrar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCN.InsertarProducto(
                    txtNombre.Text,
                    txtDesc.Text,
                    Convert.ToDecimal(txtPrecio.Text),
                    Convert.ToInt32(txtStock.Text),
                    Convert.ToInt32(CBCate.Text),
                    Convert.ToInt32(CBProvee.Text)
                );

                MessageBox.Show("Producto insertado correctamente");

                mostrarProductos();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el producto: " + ex.Message);
            }
        }
        private void limpiarCampos()
        {
            txtNombre.Clear();
            txtDesc.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            CBCate.SelectedIndex = -1;
            CBProvee.SelectedIndex = -1;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCN.ActualizarProducto(
                    idProducto,
                    txtNombre.Text,
                    txtDesc.Text,
                    Convert.ToDecimal(txtPrecio.Text),
                    Convert.ToInt32(txtStock.Text),
                    Convert.ToInt32(CBCate.Text),
                    Convert.ToInt32(CBProvee.Text)
                );

                MessageBox.Show("Producto actualizado correctamente");
                mostrarProductos();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idProducto != 0)
            {
                try
                {
                    objetoCN.EliminarProducto(idProducto);
                    MessageBox.Show("Producto eliminado correctamente");
                    mostrarProductos();
                    limpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el producto: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar.");
            }
        }
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idProducto = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtNombre.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDesc.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPrecio.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtStock.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                CBCate.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                CBProvee.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MenuAdmin menuA = new MenuAdmin();
            menuA.Show();
            this.Hide();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Trim() != "")
            {
                dataGridView1.DataSource = objetoCN.BuscarProducto(txtBuscar.Text);
            }
            else
            {
                MessageBox.Show("Ingrese el nombre del producto que desea buscar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objetoCN.BuscarProducto(txtBuscar.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
