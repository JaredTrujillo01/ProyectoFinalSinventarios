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

        //private void CargarProductos()
        //{
        //    productos = objetoCN.ObtenerProductos();
        //    if (productos == null || productos.Count == 0)
        //    {
        //        MessageBox.Show("No se han cargado productos.");
        //        return;
        //    }

        //    // Depuración: Verificar si los productos se cargaron
        //    foreach (var producto in productos)
        //    {
        //        Console.WriteLine(producto.Nombre);  // Ver en la consola si los productos están cargados
        //    }

        //    // Asegurarse de que cada fila del DataGridView tenga un ComboBox que cargue los productos
        //    foreach (DataGridViewRow row in dataGridView1.Rows)
        //    {
        //        if (row.IsNewRow) continue; // Ignorar la fila nueva

        //        // Obtener la celda que contiene el ComboBox
        //        var comboBoxCell = row.Cells["Producto"] as DataGridViewComboBoxCell;
        //        if (comboBoxCell != null)
        //        {
        //            comboBoxCell.Items.Clear(); // Limpiar los elementos anteriores
        //            foreach (var producto in productos)
        //            {
        //                comboBoxCell.Items.Add(producto.Nombre); // Agregar el nombre del producto
        //            }
        //        }
        //    }
        //}
        private void CargarProductos()
        {
            productos = objetoCN.ObtenerProductos();
            if (productos == null || productos.Count == 0)
            {
                MessageBox.Show("No se han cargado productos.");
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
            precioColumn.HeaderText = "Precio";
            precioColumn.Name = "Precio";
            dataGridView1.Columns.Add(precioColumn);

            DataGridViewTextBoxColumn subtotalColumn = new DataGridViewTextBoxColumn();
            subtotalColumn.HeaderText = "Subtotal";
            subtotalColumn.Name = "Subtotal";
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


        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            if (dataGridView1.Rows[rowIndex].Cells["Producto"].Value == null)
            {
                MessageBox.Show("Selecciona un producto válido.");
                return;
            }

            int idProducto = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["Producto"].Value);
            Producto productoSeleccionado = productos.FirstOrDefault(p => p.IdProducto == idProducto);

            if (productoSeleccionado == null)
            {
                MessageBox.Show("Producto no encontrado.");
                return;
            }

            if (!int.TryParse(dataGridView1.Rows[rowIndex].Cells["Cantidad"].Value?.ToString(), out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            decimal precioCompra = productoSeleccionado.PrecioUnitario;
            decimal subtotal = cantidad * precioCompra;

            dataGridView1.Rows[rowIndex].Cells["Precio"].Value = precioCompra;
            dataGridView1.Rows[rowIndex].Cells["Subtotal"].Value = subtotal;

            CalcularTotalCompra();
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
            CargarProductos();
            CargarProveedores();
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
                int idEmpleado = 1;
                int idProveedor = proveedores.FirstOrDefault(p => p.Nombre == cmbProveedores.SelectedItem.ToString()).IdProveedor; // Obtener el ID del proveedor
                DateTime fechaCompra = DateTime.Now;
                decimal totalCompra = Convert.ToDecimal(txtTotal.Text);

                List<DetalleCompra> detallesCompra = new List<DetalleCompra>();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    int idProducto = productos.FirstOrDefault(p => p.Nombre == row.Cells["Producto"].Value.ToString()).IdProducto;
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    decimal precioCompra = Convert.ToDecimal(row.Cells["Precio"].Value);

                    detallesCompra.Add(new DetalleCompra(idProducto, cantidad, precioCompra));
                }

                objetoCN.InsertarCompra(idEmpleado, idProveedor, fechaCompra, totalCompra, detallesCompra);

                dataGridView1.Rows.Clear();
                txtTotal.Text = "0.00";

                foreach (var detalle in detallesCompra)
                {
                    objetoCN.ActualizarStock(detalle.IdProducto, detalle.Cantidad);
                }

                MessageBox.Show("Compra realizada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la compra: " + ex.Message);
            }
        }
    }
}
