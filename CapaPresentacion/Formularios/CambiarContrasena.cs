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
    public partial class CambiarContrasena : Form
    {
        public CambiarContrasena()
        {
            InitializeComponent();
            txtPasswordActual.PasswordChar = '●';
            txtPasswordNueva.PasswordChar = '●';
            txtConfirmarPassword.PasswordChar = '●';
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string passwordActual = txtPasswordActual.Text.Trim();
            string nuevoPassword = txtPasswordNueva.Text.Trim();
            string confirmarPassword = txtConfirmarPassword.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(passwordActual) || string.IsNullOrEmpty(nuevoPassword) || string.IsNullOrEmpty(confirmarPassword))
            {
                lblError.Text = "Todos los campos son obligatorios.";
                lblError.Visible = true;
                return;
            }
            lblError.Visible = false;

            if (nuevoPassword != confirmarPassword)
            {
                lblError.Text = "Las contraseñas no coinciden.";
                lblError.Visible = true;
                return;
            }

            CN_Login loginNegocios = new CN_Login();
            bool cambioExitoso = loginNegocios.CambiarPassword(usuario, passwordActual, nuevoPassword);

            if (cambioExitoso)
            {
                MessageBox.Show("Contraseña cambiada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                InicioSesion inicioSesion = new InicioSesion();
                inicioSesion.Show();
            }
            else
            {
                MessageBox.Show("La contraseña actual es incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrar.Checked)
            {
                txtPasswordActual.PasswordChar = '\0';
                txtPasswordNueva.PasswordChar = '\0';
                txtConfirmarPassword.PasswordChar = '\0';
            }
            else
            {
                txtPasswordActual.PasswordChar = '●';
                txtPasswordNueva.PasswordChar = '●';
                txtConfirmarPassword.PasswordChar = '●';
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicioSesion login = new InicioSesion();
            login.Show();
            this.Hide();
        }
    }
}
