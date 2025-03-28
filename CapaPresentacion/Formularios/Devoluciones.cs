using CapaDatos;
using CapaNegocio;
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
    public partial class Devoluciones : Form
    {
        private readonly CN_Devoluciones objNegocio = new CN_Devoluciones();
        public Devoluciones()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MenuVendedor vendedor = new MenuVendedor();
            vendedor.Show();
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cmbVenta.SelectedValue == null || cmbProducto.SelectedValue == null ||
                string.IsNullOrWhiteSpace(txtCantidad.Text) || string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            int idVenta = (cmbVenta.SelectedValue is DataRowView) ? Convert.ToInt32(((DataRowView)cmbVenta.SelectedValue)["IdVenta"]) : Convert.ToInt32(cmbVenta.SelectedValue);
            int idProducto = (cmbProducto.SelectedValue is DataRowView) ? Convert.ToInt32(((DataRowView)cmbProducto.SelectedValue)["IdProducto"]) : Convert.ToInt32(cmbProducto.SelectedValue);

            int cantidad = int.Parse(txtCantidad.Text);
            string motivo = txtMotivo.Text;
            string estado = cmbEstado.SelectedItem.ToString();

            objNegocio.RegistrarDevolucion(idVenta, idProducto, cantidad, motivo, estado);
            MessageBox.Show("Devolución registrada correctamente.");

            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            cmbVenta.SelectedIndex = -1; 
            cmbProducto.SelectedIndex = -1; 
            cmbEstado.SelectedIndex = -1;

            txtCantidad.Clear();
            txtMotivo.Clear();
        }

        private void Devoluciones_Load(object sender, EventArgs e)
        {
            CargarVentas();
        }

        private void CargarVentas()
        {
            DataTable dtVentas = objNegocio.ObtenerVentas();
            cmbVenta.DataSource = dtVentas;
            cmbVenta.DisplayMember = "ClienteInfo"; 
            cmbVenta.ValueMember = "IdVenta"; 
        }
        private void CargarProductos(int idVenta)
        {
            DataTable dtProductos = objNegocio.ObtenerProductosPorVenta(idVenta);
            cmbProducto.DataSource = dtProductos;
            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "IdProducto";
        }
        private void cmbVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVenta.SelectedValue != null)
            {
                DataRowView selectedRow = (DataRowView)cmbVenta.SelectedItem;
                int idVenta = Convert.ToInt32(selectedRow["IdVenta"]); 

                CargarProductos(idVenta);
            }
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedValue != null)
            {
                int idVenta = Convert.ToInt32(cmbVenta.SelectedValue);
                int idProducto = Convert.ToInt32(cmbProducto.SelectedValue);
                int cantidadVendida = objNegocio.ObtenerCantidadVendida(idVenta, idProducto);

                if (int.TryParse(txtCantidad.Text, out int cantidadIngresada))
                {
                    if (cantidadIngresada > cantidadVendida)
                    {
                        MessageBox.Show("La cantidad ingresada supera la cantidad vendida.");
                        txtCantidad.Text = cantidadVendida.ToString();
                    }
                }
            }
        }
    }
}
