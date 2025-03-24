namespace CapaPresentacion
{
    partial class InicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            chkMostrar = new CheckBox();
            btnEntrar = new Button();
            btnRegistrar = new Button();
            pictureBox1 = new PictureBox();
            lblErrorUsuario = new Label();
            lblErrorPassword = new Label();
            txtCambiarPass = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 112);
            label1.Name = "label1";
            label1.Size = new Size(207, 31);
            label1.TabIndex = 0;
            label1.Text = "Inicio de Sesion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F);
            label2.Location = new Point(70, 163);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F);
            label3.Location = new Point(50, 223);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(129, 163);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(204, 22);
            txtUsuario.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(129, 223);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(204, 22);
            txtPassword.TabIndex = 4;
            // 
            // chkMostrar
            // 
            chkMostrar.AutoSize = true;
            chkMostrar.Font = new Font("Microsoft Sans Serif", 9F);
            chkMostrar.Location = new Point(223, 268);
            chkMostrar.Margin = new Padding(3, 2, 3, 2);
            chkMostrar.Name = "chkMostrar";
            chkMostrar.Size = new Size(134, 19);
            chkMostrar.TabIndex = 5;
            chkMostrar.Text = "Mostrar Contraseña";
            chkMostrar.UseVisualStyleBackColor = true;
            chkMostrar.CheckedChanged += chkMostrar_CheckedChanged;
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Microsoft Sans Serif", 9F);
            btnEntrar.Location = new Point(129, 291);
            btnEntrar.Margin = new Padding(3, 2, 3, 2);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(133, 29);
            btnEntrar.TabIndex = 6;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Microsoft Sans Serif", 9F);
            btnRegistrar.Location = new Point(12, 326);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(81, 29);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(124, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // lblErrorUsuario
            // 
            lblErrorUsuario.AutoSize = true;
            lblErrorUsuario.ForeColor = Color.Red;
            lblErrorUsuario.Location = new Point(129, 192);
            lblErrorUsuario.Name = "lblErrorUsuario";
            lblErrorUsuario.Size = new Size(38, 13);
            lblErrorUsuario.TabIndex = 9;
            lblErrorUsuario.Text = "label4";
            lblErrorUsuario.Visible = false;
            // 
            // lblErrorPassword
            // 
            lblErrorPassword.AutoSize = true;
            lblErrorPassword.ForeColor = Color.Red;
            lblErrorPassword.Location = new Point(129, 250);
            lblErrorPassword.Name = "lblErrorPassword";
            lblErrorPassword.Size = new Size(38, 13);
            lblErrorPassword.TabIndex = 10;
            lblErrorPassword.Text = "label4";
            lblErrorPassword.Visible = false;
            // 
            // txtCambiarPass
            // 
            txtCambiarPass.Font = new Font("Microsoft Sans Serif", 9F);
            txtCambiarPass.Location = new Point(248, 326);
            txtCambiarPass.Margin = new Padding(3, 2, 3, 2);
            txtCambiarPass.Name = "txtCambiarPass";
            txtCambiarPass.Size = new Size(136, 29);
            txtCambiarPass.TabIndex = 11;
            txtCambiarPass.Text = "Cambiar Contraseña";
            txtCambiarPass.UseVisualStyleBackColor = true;
            txtCambiarPass.Click += txtCambiarPass_Click;
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(396, 366);
            Controls.Add(txtCambiarPass);
            Controls.Add(lblErrorPassword);
            Controls.Add(lblErrorUsuario);
            Controls.Add(pictureBox1);
            Controls.Add(btnRegistrar);
            Controls.Add(btnEntrar);
            Controls.Add(chkMostrar);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio Sesion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private CheckBox chkMostrar;
        private Button btnEntrar;
        private Button btnRegistrar;
        private PictureBox pictureBox1;
        private Label lblErrorUsuario;
        private Label lblErrorPassword;
        private Button txtCambiarPass;
    }
}