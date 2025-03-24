namespace CapaPresentacion.Formularios
{
    partial class Registro
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
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtApellido = new TextBox();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            label6 = new Label();
            cmbCargo = new ComboBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            lblErrorNombre = new Label();
            lblErrorApellido = new Label();
            lblErrorUsuario = new Label();
            lblErrorContrasena = new Label();
            lblErrorCargo = new Label();
            chkMostrar = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(156, 9);
            label1.Name = "label1";
            label1.Size = new Size(280, 31);
            label1.TabIndex = 1;
            label1.Text = "Registro de Empleado";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Arial", 9.75F);
            txtNombre.Location = new Point(74, 60);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(190, 22);
            txtNombre.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F);
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(56, 16);
            label2.TabIndex = 8;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F);
            label3.Location = new Point(305, 66);
            label3.Name = "label3";
            label3.Size = new Size(53, 16);
            label3.TabIndex = 9;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F);
            label4.Location = new Point(17, 121);
            label4.Name = "label4";
            label4.Size = new Size(55, 16);
            label4.TabIndex = 10;
            label4.Text = "Usuario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F);
            label5.Location = new Point(281, 121);
            label5.Name = "label5";
            label5.Size = new Size(77, 16);
            label5.TabIndex = 11;
            label5.Text = "Contraseña:";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Arial", 9.75F);
            txtApellido.Location = new Point(364, 60);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(210, 22);
            txtApellido.TabIndex = 12;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Arial", 9.75F);
            txtUsuario.Location = new Point(74, 118);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(190, 22);
            txtUsuario.TabIndex = 13;
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Arial", 9.75F);
            txtContrasena.Location = new Point(364, 118);
            txtContrasena.Margin = new Padding(3, 2, 3, 2);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(210, 22);
            txtContrasena.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F);
            label6.Location = new Point(23, 190);
            label6.Name = "label6";
            label6.Size = new Size(45, 16);
            label6.TabIndex = 15;
            label6.Text = "Cargo:";
            // 
            // cmbCargo
            // 
            cmbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCargo.Font = new Font("Arial", 9.75F);
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Items.AddRange(new object[] { "Administrador", "Vendedor" });
            cmbCargo.Location = new Point(74, 187);
            cmbCargo.Margin = new Padding(3, 2, 3, 2);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(190, 24);
            cmbCargo.TabIndex = 16;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Arial", 9.75F);
            btnGuardar.Location = new Point(305, 190);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(114, 28);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Arial", 9.75F);
            btnCancelar.Location = new Point(452, 190);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 28);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblErrorNombre
            // 
            lblErrorNombre.AutoSize = true;
            lblErrorNombre.ForeColor = Color.Red;
            lblErrorNombre.Location = new Point(74, 94);
            lblErrorNombre.Name = "lblErrorNombre";
            lblErrorNombre.Size = new Size(38, 13);
            lblErrorNombre.TabIndex = 19;
            lblErrorNombre.Text = "label7";
            lblErrorNombre.Visible = false;
            // 
            // lblErrorApellido
            // 
            lblErrorApellido.AutoSize = true;
            lblErrorApellido.ForeColor = Color.Red;
            lblErrorApellido.Location = new Point(364, 94);
            lblErrorApellido.Name = "lblErrorApellido";
            lblErrorApellido.Size = new Size(38, 13);
            lblErrorApellido.TabIndex = 20;
            lblErrorApellido.Text = "label7";
            lblErrorApellido.Visible = false;
            // 
            // lblErrorUsuario
            // 
            lblErrorUsuario.AutoSize = true;
            lblErrorUsuario.ForeColor = Color.Red;
            lblErrorUsuario.Location = new Point(74, 155);
            lblErrorUsuario.Name = "lblErrorUsuario";
            lblErrorUsuario.Size = new Size(38, 13);
            lblErrorUsuario.TabIndex = 21;
            lblErrorUsuario.Text = "label8";
            lblErrorUsuario.Visible = false;
            // 
            // lblErrorContrasena
            // 
            lblErrorContrasena.AutoSize = true;
            lblErrorContrasena.ForeColor = Color.Red;
            lblErrorContrasena.Location = new Point(364, 155);
            lblErrorContrasena.Name = "lblErrorContrasena";
            lblErrorContrasena.Size = new Size(38, 13);
            lblErrorContrasena.TabIndex = 22;
            lblErrorContrasena.Text = "label9";
            lblErrorContrasena.Visible = false;
            // 
            // lblErrorCargo
            // 
            lblErrorCargo.AutoSize = true;
            lblErrorCargo.ForeColor = Color.Red;
            lblErrorCargo.Location = new Point(74, 228);
            lblErrorCargo.Name = "lblErrorCargo";
            lblErrorCargo.Size = new Size(44, 13);
            lblErrorCargo.TabIndex = 23;
            lblErrorCargo.Text = "label10";
            lblErrorCargo.Visible = false;
            // 
            // chkMostrar
            // 
            chkMostrar.AutoSize = true;
            chkMostrar.Font = new Font("Microsoft Sans Serif", 9F);
            chkMostrar.Location = new Point(434, 167);
            chkMostrar.Margin = new Padding(3, 2, 3, 2);
            chkMostrar.Name = "chkMostrar";
            chkMostrar.Size = new Size(134, 19);
            chkMostrar.TabIndex = 26;
            chkMostrar.Text = "Mostrar Contraseña";
            chkMostrar.UseVisualStyleBackColor = true;
            chkMostrar.CheckedChanged += chkMostrar_CheckedChanged;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 259);
            Controls.Add(chkMostrar);
            Controls.Add(lblErrorCargo);
            Controls.Add(lblErrorContrasena);
            Controls.Add(lblErrorUsuario);
            Controls.Add(lblErrorApellido);
            Controls.Add(lblErrorNombre);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbCargo);
            Controls.Add(label6);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(txtApellido);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtApellido;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Label label6;
        private ComboBox cmbCargo;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label lblErrorNombre;
        private Label lblErrorApellido;
        private Label lblErrorUsuario;
        private Label lblErrorContrasena;
        private Label lblErrorCargo;
        private CheckBox chkMostrar;
    }
}