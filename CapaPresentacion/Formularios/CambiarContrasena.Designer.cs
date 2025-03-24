namespace CapaPresentacion.Formularios
{
    partial class CambiarContrasena
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarContrasena));
            pictureBox1 = new PictureBox();
            btnConfirmar = new Button();
            txtPasswordActual = new TextBox();
            txtUsuario = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPasswordNueva = new TextBox();
            label5 = new Label();
            lblError = new Label();
            txtConfirmarPassword = new TextBox();
            label4 = new Label();
            chkMostrar = new CheckBox();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(103, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Microsoft Sans Serif", 9F);
            btnConfirmar.Location = new Point(108, 369);
            btnConfirmar.Margin = new Padding(3, 2, 3, 2);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(133, 29);
            btnConfirmar.TabIndex = 16;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtPasswordActual
            // 
            txtPasswordActual.Location = new Point(144, 226);
            txtPasswordActual.Margin = new Padding(3, 2, 3, 2);
            txtPasswordActual.Name = "txtPasswordActual";
            txtPasswordActual.Size = new Size(204, 23);
            txtPasswordActual.TabIndex = 15;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(144, 166);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(204, 23);
            txtUsuario.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F);
            label3.Location = new Point(29, 228);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 13;
            label3.Text = "Contraseña Actual:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F);
            label2.Location = new Point(85, 168);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 12;
            label2.Text = "Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 112);
            label1.Name = "label1";
            label1.Size = new Size(260, 31);
            label1.TabIndex = 11;
            label1.Text = "Cambiar contraseña";
            // 
            // txtPasswordNueva
            // 
            txtPasswordNueva.Location = new Point(144, 282);
            txtPasswordNueva.Margin = new Padding(3, 2, 3, 2);
            txtPasswordNueva.Name = "txtPasswordNueva";
            txtPasswordNueva.Size = new Size(204, 23);
            txtPasswordNueva.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F);
            label5.Location = new Point(27, 284);
            label5.Name = "label5";
            label5.Size = new Size(111, 15);
            label5.TabIndex = 20;
            label5.Text = "Contraseña Nueva:";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(12, 350);
            lblError.Name = "lblError";
            lblError.Size = new Size(25, 15);
            lblError.TabIndex = 22;
            lblError.Text = " ---";
            lblError.Visible = false;
            // 
            // txtConfirmarPassword
            // 
            txtConfirmarPassword.Location = new Point(144, 316);
            txtConfirmarPassword.Margin = new Padding(3, 2, 3, 2);
            txtConfirmarPassword.Name = "txtConfirmarPassword";
            txtConfirmarPassword.Size = new Size(204, 23);
            txtConfirmarPassword.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F);
            label4.Location = new Point(12, 318);
            label4.Name = "label4";
            label4.Size = new Size(128, 15);
            label4.TabIndex = 23;
            label4.Text = "Confirmar contraseña:";
            // 
            // chkMostrar
            // 
            chkMostrar.AutoSize = true;
            chkMostrar.Font = new Font("Microsoft Sans Serif", 9F);
            chkMostrar.Location = new Point(214, 346);
            chkMostrar.Margin = new Padding(3, 2, 3, 2);
            chkMostrar.Name = "chkMostrar";
            chkMostrar.Size = new Size(140, 19);
            chkMostrar.TabIndex = 25;
            chkMostrar.Text = "Mostrar Contraseñas";
            chkMostrar.UseVisualStyleBackColor = true;
            chkMostrar.CheckedChanged += chkMostrar_CheckedChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Microsoft Sans Serif", 9F);
            btnCancelar.Location = new Point(108, 404);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(133, 29);
            btnCancelar.TabIndex = 26;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // CambiarContrasena
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 444);
            Controls.Add(btnCancelar);
            Controls.Add(chkMostrar);
            Controls.Add(txtConfirmarPassword);
            Controls.Add(label4);
            Controls.Add(lblError);
            Controls.Add(txtPasswordNueva);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(btnConfirmar);
            Controls.Add(txtPasswordActual);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CambiarContrasena";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cambiar Contraseña";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblErrorPassword;
        private Label lblErrorUsuario;
        private PictureBox pictureBox1;
        private Button btnConfirmar;
        private TextBox txtPasswordActual;
        private TextBox txtUsuario;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPasswordNueva;
        private Label label5;
        private Label lblError;
        private TextBox txtConfirmarPassword;
        private Label label4;
        private CheckBox chkMostrar;
        private Button btnCancelar;
    }
}