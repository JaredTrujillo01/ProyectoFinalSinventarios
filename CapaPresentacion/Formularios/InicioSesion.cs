using CapaNegocios;
using CapaPresentacion.Formularios;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class InicioSesion : Form
    {
        CN_Login login = new CN_Login();
        public InicioSesion()
        {
            InitializeComponent();
            OcultarMensajesError();
            txtPassword.PasswordChar = '●';
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();

            string nombreCompleto, rol;

            OcultarMensajesError();

            bool camposValidos = true;
            if (string.IsNullOrEmpty(usuario))
            {
                lblErrorUsuario.Text = "Ingrese su usuario.";
                lblErrorUsuario.Visible = true;
                camposValidos = false;
            }
            if (string.IsNullOrEmpty(password))
            {
                lblErrorPassword.Text = "Ingrese su contraseña.";
                lblErrorPassword.Visible = true;
                camposValidos = false;
            }

            if (!camposValidos) return;

            if (login.IniciarSesion(usuario, password, out nombreCompleto, out rol))
            {
                MessageBox.Show("Bienvenido, " + nombreCompleto, "Inicio de Sesión Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (rol == "Administrador")
                {
                    MenuAdmin menuAdmin = new MenuAdmin();
                    menuAdmin.Show();
                }
                else if (rol == "Vendedor")
                {
                    MenuVendedor menuVendedor = new MenuVendedor();
                    menuVendedor.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OcultarMensajesError()
        {
            lblErrorUsuario.Visible = false;
            lblErrorPassword.Visible = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Hide();
        }

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrar.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '●';
            }
        }

        private void txtCambiarPass_Click(object sender, EventArgs e)
        {
            CambiarContrasena cambiarContrasena = new CambiarContrasena();
            cambiarContrasena.Show();
            this.Hide();
        }
    }
}
