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
    public partial class Registro : Form
    {
        CN_Empleados objetoCN = new CN_Empleados();
        public Registro()
        {
            InitializeComponent();
            OcultarMensajesError();
            cmbCargo.SelectedItem = 1;
            txtContrasena.PasswordChar = '●';
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text.Trim();
                string apellido = txtApellido.Text.Trim();
                string usuario = txtUsuario.Text.Trim();
                string password = txtContrasena.Text.Trim();
                string rol = cmbCargo.Text.Trim();

                bool camposValidos = true;
                OcultarMensajesError();

                if (string.IsNullOrEmpty(nombre))
                {
                    lblErrorNombre.Text = "Ingrese el nombre.";
                    lblErrorNombre.Visible = true;
                    camposValidos = false;
                }

                if (string.IsNullOrEmpty(apellido))
                {
                    lblErrorApellido.Text = "Ingrese el apellido.";
                    lblErrorApellido.Visible = true;
                    camposValidos = false;
                }

                if (string.IsNullOrEmpty(usuario))
                {
                    lblErrorUsuario.Text = "Ingrese el usuario.";
                    lblErrorUsuario.Visible = true;
                    camposValidos = false;
                }

                if (string.IsNullOrEmpty(password))
                {
                    lblErrorContrasena.Text = "Ingrese la contraseña.";
                    lblErrorContrasena.Visible = true;
                    camposValidos = false;
                }

                if (string.IsNullOrEmpty(rol))
                {
                    lblErrorCargo.Text = "Seleccione un rol.";
                    lblErrorCargo.Visible = true;
                    camposValidos = false;
                }

                if (!camposValidos) return;

                objetoCN.AgregarEmpleado(nombre, apellido, usuario, password, rol);

                MessageBox.Show("Empleado agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OcultarMensajesError()
        {
            lblErrorNombre.Visible = false;
            lblErrorApellido.Visible = false;
            lblErrorUsuario.Visible = false;
            lblErrorContrasena.Visible = false;
            lblErrorCargo.Visible = false;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtUsuario.Clear();
            txtContrasena.Clear();
            cmbCargo.SelectedIndex = -1;
            OcultarMensajesError();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicioSesion login = new InicioSesion();
            login.Show();
            this.Hide();
        }

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrar.Checked)
            {
                txtContrasena.PasswordChar = '\0';
            }
            else
            {
                txtContrasena.PasswordChar = '●';
            }
        }
    }
}
