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
using CapaDatos;

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
            CargarCategorias();
            CargarProveedores();
        }

        private void mostrarProductos()
        {
            CN_Producto objeto = new CN_Producto();
            dataGridView1.DataSource = objeto.Mostrar();
        }

        private void CargarCategorias()
        {
            CN_Producto objeto = new CN_Producto();
            CBCate.DataSource = objeto.ObtenerCategorias();
            CBCate.DisplayMember = "Nombre";  
            CBCate.ValueMember = "IdCategoria"; 
            CBCate.SelectedIndex = -1;
        }
        private void CargarProveedores()
        {
            CN_Producto objeto = new CN_Producto();
            CBProvee.DataSource = objeto.ObtenerProveedores();
            CBProvee.DisplayMember = "Nombre";
            CBProvee.ValueMember = "IdProveedor";
            CBProvee.SelectedIndex = -1; 
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
                    Convert.ToInt32(CBProvee.SelectedValue),
                    Convert.ToInt32(CBCate.SelectedValue)
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
                    Convert.ToInt32(CBProvee.SelectedValue),
                    Convert.ToInt32(CBCate.SelectedValue)
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

                int idProveedor = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                int idCategoria = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value);

                // Forzamos la actualización de los ComboBox antes de asignar SelectedValue
                CargarCategorias();
                CargarProveedores();

                // Esperamos a que los datos se carguen completamente
                CBCate.SelectedIndex = -1;
                CBProvee.SelectedIndex = -1;
                CBCate.SelectedValue = idCategoria;
                CBProvee.SelectedValue = idProveedor;

                // Si el valor no se asigna correctamente, mostramos una alerta
                if (CBCate.SelectedValue == null || (int)CBCate.SelectedValue != idCategoria)
                {
                    MessageBox.Show($"No se encontró la categoría con ID {idCategoria}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (CBProvee.SelectedValue == null || (int)CBProvee.SelectedValue != idProveedor)
                {
                    MessageBox.Show($"No se encontró el proveedor con ID {idProveedor}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Sesion.Rol == "Administrador")
            {
                MenuAdmin menuA = new MenuAdmin();
                menuA.Show();
            }
            else if (Sesion.Rol == "Vendedor")
            {
                MenuVendedor menuV = new MenuVendedor();
                menuV.Show();
            }
            else
            {
                MessageBox.Show("Rol no reconocido. No se puede redirigir al menú correspondiente.");
                return;
            }

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
