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
    public partial class Ventas : Form
    {
        private CN_Venta objetoCN = new CN_Venta();
        private List<Producto> productos;
        private List<Cliente> clientes;
        public Ventas()
        {
            InitializeComponent();
        }
        private void CargarClientes()
        {
            clientes = objetoCN.ObtenerClientes();
            cmbCliente.Items.Clear();

            foreach (var cliente in clientes)
            {
                cmbCliente.Items.Add(cliente.DNI + " - " + cliente.Nombre + " " + cliente.Apellido);
            }

            cmbCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCliente.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void CargarProductos()
        {
            productos = objetoCN.ObtenerProductos();

            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.HeaderText = "Producto";
            comboBoxColumn.Name = "Producto";
            comboBoxColumn.DisplayMember = "NombreProductoConProveedor"; 
            comboBoxColumn.ValueMember = "IdProducto"; 

            foreach (var producto in productos)
            {
                var productoConProveedor = new
                {
                    IdProducto = producto.IdProducto,
                    NombreProductoConProveedor = producto.Nombre + " - " + producto.ProveedorNombre
                };

                comboBoxColumn.Items.Add(productoConProveedor); 
            }

            dataGridView1.Columns.Add(comboBoxColumn);
        }

        private void ConfigurarDataGridView()
        {
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

        private void CalcularTotalCompra()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
            }

            txtTotal.Text = total.ToString("F2");
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MenuVendedor ven = new MenuVendedor();
            ven.Show();
            this.Hide();
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                txtTotal.Clear();

                if (cmbCliente.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un cliente.");
                    return;
                }

                string clienteSeleccionado = cmbCliente.SelectedItem.ToString();
                int idCliente = clientes.FirstOrDefault(c => clienteSeleccionado.StartsWith(c.DNI))?.IdCliente ?? 0;

                if (idCliente == 0)
                {
                    MessageBox.Show("Cliente no válido.");
                    return;
                }

                int idEmpleado = Sesion.IdEmpleado;
                DateTime fechaVenta = DateTime.Now;
                decimal totalVenta = 0;
                List<(int IdProducto, int Cantidad, decimal PrecioVenta)> detallesVenta = new List<(int, int, decimal)>();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    if (row.Cells["Producto"].Value == null || row.Cells["Cantidad"].Value == null)
                    {
                        MessageBox.Show("Asegúrese de seleccionar un producto y una cantidad válida.");
                        return;
                    }

                    string productoSeleccionado = row.Cells["Producto"].Value.ToString();
                    int idProducto = Convert.ToInt32(productoSeleccionado.Split('-')[0]);
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    decimal precioVenta = productos.FirstOrDefault(p => p.IdProducto == idProducto)?.PrecioUnitario ?? 0;

                    if (cantidad <= 0 || precioVenta <= 0)
                    {
                        MessageBox.Show("Cantidad o precio inválido para un producto.");
                        return;
                    }

                    Producto producto = objetoCN.ObtenerProductoPorId(idProducto); 

                    if (producto != null && producto.Stock < cantidad)
                    {
                        MessageBox.Show($"Stock insuficiente para el producto {producto.Nombre}. Solo quedan {producto.Stock} en stock.");
                        return;
                    }

                    detallesVenta.Add((idProducto, cantidad, precioVenta));

                    decimal subtotal = cantidad * precioVenta;
                    totalVenta += subtotal;
                }

                txtTotal.Text = totalVenta.ToString("F2");

                int idVenta = objetoCN.InsertarVenta(idCliente, idEmpleado, fechaVenta, totalVenta, detallesVenta);
                if (idVenta == 0)
                {
                    MessageBox.Show("Error al registrar la venta.");
                    return;
                }

                foreach (var detalle in detallesVenta)
                {
                    bool stockActualizado = objetoCN.ActualizarStock(detalle.IdProducto, detalle.Cantidad);
                    if (!stockActualizado)
                    {
                        MessageBox.Show($"Error al actualizar el stock para el producto con ID: {detalle.IdProducto}");
                        return;
                    }

                    Producto producto = productos.FirstOrDefault(p => p.IdProducto == detalle.IdProducto);
                    if (producto != null)
                    {
                        producto.Stock -= detalle.Cantidad;
                    }
                }

                dataGridView1.Rows.Clear();
                MessageBox.Show("Venta realizada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la venta: " + ex.Message);
            }
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CargarClientes();
            CargarProductos();
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

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Producto"].Index && e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                if (row.Cells["Producto"].Value == null) return;

                var productoSeleccionado = row.Cells["Producto"].Value.ToString();
                int idProducto = Convert.ToInt32(productoSeleccionado.Split('-')[0]);

                Producto producto = productos.FirstOrDefault(p => p.IdProducto == idProducto);

                if (producto != null)
                {
                    row.Cells["PrecioUnitario"].Value = producto.PrecioUnitario;
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
    }
}
