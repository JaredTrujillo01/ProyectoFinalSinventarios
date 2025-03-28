using CapaDatos;
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

namespace CapaPresentacion.Formularios
{
    public partial class Compras : Form
    {
        private CN_Compra objetoCN = new CN_Compra();
        private List<Producto> productos;
        private List<Proveedor> proveedores;

        public Compras()
        {
            InitializeComponent();
            //CargarProductos();
            //CargarProveedores();
        }
        private void CargarProductos(int idProveedor)
        {
            productos = objetoCN.ObtenerProductosPorProveedor(idProveedor);
            if (productos == null || productos.Count == 0)
            {
                MessageBox.Show("No se han cargado productos para este proveedor.");
                return;
            }

            var comboBoxColumn = dataGridView1.Columns["Producto"] as DataGridViewComboBoxColumn;
            if (comboBoxColumn != null)
            {
                comboBoxColumn.DataSource = productos;
                comboBoxColumn.DisplayMember = "Nombre";
                comboBoxColumn.ValueMember = "IdProducto";
            }
        }

        private void CargarProveedores()
        {
            proveedores = objetoCN.ObtenerProveedores();
            if (proveedores.Count == 0)
            {
                MessageBox.Show("No se encontraron proveedores.");
            }

            cmbProveedores.Items.Clear();
            foreach (var proveedor in proveedores)
            {
                cmbProveedores.Items.Add(proveedor.Nombre);
            }
        }
        private void ConfigurarDataGridView()
        {
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.HeaderText = "Producto";
            comboBoxColumn.Name = "Producto";
            comboBoxColumn.DataPropertyName = "IdProducto";
            comboBoxColumn.DisplayMember = "Nombre";
            comboBoxColumn.ValueMember = "IdProducto";

            dataGridView1.Columns.Add(comboBoxColumn);

            DataGridViewTextBoxColumn cantidadColumn = new DataGridViewTextBoxColumn();
            cantidadColumn.HeaderText = "Cantidad";
            cantidadColumn.Name = "Cantidad";
            dataGridView1.Columns.Add(cantidadColumn);

            DataGridViewTextBoxColumn precioColumn = new DataGridViewTextBoxColumn();
            precioColumn.HeaderText = "PrecioUnitario";
            precioColumn.Name = "PrecioUnitario";
            precioColumn.ReadOnly = true;
            dataGridView1.Columns.Add(precioColumn);

            DataGridViewTextBoxColumn subtotalColumn = new DataGridViewTextBoxColumn();
            subtotalColumn.HeaderText = "Subtotal";
            subtotalColumn.Name = "Subtotal";
            subtotalColumn.ReadOnly = true;
            dataGridView1.Columns.Add(subtotalColumn);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MenuAdmin menuA = new MenuAdmin();
            menuA.Show();
            this.Hide();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            MenuAdmin menuA = new MenuAdmin();
            menuA.Show();
            this.Hide();
        }
        private void CalcularTotalCompra()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
            }

            txtTotal.Text = total.ToString("F2");
        }

        private void btnCancelar_Click_2(object sender, EventArgs e)
        {
            MenuAdmin menuA = new MenuAdmin();
            menuA.Show();
            this.Hide();
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CargarProveedores();
            if (proveedores.Count > 0)
            {
                cmbProveedores.SelectedIndex = 0; 
                CargarProductos(proveedores[0].IdProveedor); 
            }
            cmbProveedores.SelectedIndexChanged += cmbProveedores_SelectedIndexChanged;

            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;

        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                CalcularTotalCompra();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        }

        private void btnRealizarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProveedores.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un proveedor.");
                    return;
                }

                int idEmpleado = Sesion.IdEmpleado;
                int idProveedor = proveedores.FirstOrDefault(p => p.Nombre == cmbProveedores.SelectedItem.ToString())?.IdProveedor ?? 0;
                if (idProveedor == 0)
                {
                    MessageBox.Show("Proveedor no válido.");
                    return;
                }

                DateTime fechaCompra = DateTime.Now;
                decimal totalCompra = 0;
                List<DetalleCompra> detallesCompra = new List<DetalleCompra>();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    if (row.Cells["Producto"].Value == null || row.Cells["Cantidad"].Value == null)
                    {
                        MessageBox.Show("Asegúrese de seleccionar un producto y una cantidad válida.");
                        return;
                    }

                    int idProducto = Convert.ToInt32(row.Cells["Producto"].Value);
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    decimal precioCompra = productos.FirstOrDefault(p => p.IdProducto == idProducto)?.PrecioUnitario ?? 0;

                    if (cantidad <= 0 || precioCompra <= 0)
                    {
                        MessageBox.Show("Cantidad o precio inválido para un producto.");
                        return;
                    }

                    detallesCompra.Add(new DetalleCompra(idProducto, cantidad, precioCompra));
                    totalCompra += cantidad * precioCompra;
                }

                int idCompra = objetoCN.InsertarCompra(idEmpleado, idProveedor, fechaCompra, totalCompra, detallesCompra);
                if (idCompra == 0)
                {
                    MessageBox.Show("Error al registrar la compra.");
                    return;
                }

                foreach (var detalle in detallesCompra)
                {
                    objetoCN.ActualizarStock(detalle.IdProducto, detalle.Cantidad);
                }

                dataGridView1.Rows.Clear();
                txtTotal.Text = "0.00";
                MessageBox.Show("Compra realizada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la compra: " + ex.Message);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Producto"].Index && e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                if (row.Cells["Producto"].Value == null) return;

                int idProducto = Convert.ToInt32(row.Cells["Producto"].Value);
                Producto productoSeleccionado = productos.FirstOrDefault(p => p.IdProducto == idProducto);

                if (productoSeleccionado != null)
                {
                    row.Cells["PrecioUnitario"].Value = productoSeleccionado.PrecioUnitario;
                    CalcularSubtotal(row);
                }
            }
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Cantidad"].Index && e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                CalcularSubtotal(row);
            }
        }

        private void CalcularSubtotal(DataGridViewRow row)
        {
            if (row.Cells["Cantidad"].Value != null && row.Cells["PrecioUnitario"].Value != null)
            {
                if (int.TryParse(row.Cells["Cantidad"].Value.ToString(), out int cantidad) && cantidad > 0)
                {
                    decimal precio = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value);
                    row.Cells["Subtotal"].Value = cantidad * precio;

                    CalcularTotalCompra();
                }
                else
                {
                    row.Cells["Subtotal"].Value = 0;
                }
            }
        }
        private void cmbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProveedores.SelectedItem != null)
            {
                string nombreProveedor = cmbProveedores.SelectedItem.ToString();
                int idProveedor = proveedores.FirstOrDefault(p => p.Nombre == nombreProveedor)?.IdProveedor ?? 0;

                if (idProveedor > 0)
                {
                    CargarProductos(idProveedor);
                }
                else
                {
                    MessageBox.Show("Proveedor no válido.");
                }
            }
        }

    }
}
