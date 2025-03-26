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
    public partial class Categorias : Form
    {
        CN_Categoria objetoCN = new CN_Categoria();
        int CategoriaId = 0;
        public Categorias()
        {
            InitializeComponent();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            mostrarCategorias();
        }

        public void mostrarCategorias()
        {

            CN_Categoria objeto = new CN_Categoria();
            dataGridView1.DataSource = objeto.MostrarCategoria();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCN.InsertarCategoria(
                    txtNombre.Text
                );
                MessageBox.Show("Categoria Insertada con exito");
                mostrarCategorias();
                limpiarcampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Categoria no se agrego por que: " + ex);
            }
        }
        private void limpiarcampos()
        {
            txtNombre.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (CategoriaId != 0)
            {
                try
                {
                    objetoCN.EliminarCategoria(CategoriaId);
                    MessageBox.Show("Categoria eliminado correctamente");
                    mostrarCategorias();
                    limpiarcampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la categoria: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                CategoriaId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdCategoria"].Value);
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una categoria");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MenuAdmin menuA = new MenuAdmin();
            menuA.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Trim() != "")
            {
                dataGridView1.DataSource = objetoCN.BuscarCate(txtBuscar.Text);
            }
            else
            {
                MessageBox.Show("Ingrese el usuario que desea buscar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objetoCN.BuscarCate(txtBuscar.Text);
        }
    }
}
