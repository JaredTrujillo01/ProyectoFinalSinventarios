namespace CapaPresentacion.Formularios
{
    partial class Clintes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clintes));
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            btnActualizar = new Button();
            txtBuscar = new TextBox();
            BtnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 9);
            label2.Name = "label2";
            label2.Size = new Size(259, 32);
            label2.TabIndex = 25;
            label2.Text = "Gestión de Clientes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F);
            label3.Location = new Point(4, 67);
            label3.Name = "label3";
            label3.Size = new Size(83, 22);
            label3.TabIndex = 26;
            label3.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F);
            label1.Location = new Point(9, 103);
            label1.Name = "label1";
            label1.Size = new Size(84, 22);
            label1.TabIndex = 27;
            label1.Text = "Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F);
            label4.Location = new Point(39, 137);
            label4.Name = "label4";
            label4.Size = new Size(48, 22);
            label4.TabIndex = 28;
            label4.Text = "DNI:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F);
            label5.Location = new Point(4, 211);
            label5.Name = "label5";
            label5.Size = new Size(89, 22);
            label5.TabIndex = 29;
            label5.Text = "Telefono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F);
            label6.Location = new Point(9, 173);
            label6.Name = "label6";
            label6.Size = new Size(79, 22);
            label6.TabIndex = 30;
            label6.Text = "Correo: ";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(89, 66);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(289, 27);
            txtNombre.TabIndex = 31;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(89, 102);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(289, 27);
            txtApellido.TabIndex = 32;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(89, 137);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(289, 27);
            txtDNI.TabIndex = 33;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(89, 210);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(289, 27);
            txtTelefono.TabIndex = 34;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(89, 172);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(289, 27);
            txtCorreo.TabIndex = 35;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(144, 330);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 58);
            btnCancelar.TabIndex = 38;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(145, 263);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 61);
            btnEliminar.TabIndex = 37;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(29, 261);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(106, 63);
            btnGuardar.TabIndex = 36;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(400, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(655, 358);
            dataGridView1.TabIndex = 39;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(400, 21);
            label7.Name = "label7";
            label7.Size = new Size(143, 21);
            label7.TabIndex = 40;
            label7.Text = "Lista de Clientes";
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Image = (Image)resources.GetObject("btnActualizar.Image");
            btnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizar.Location = new Point(265, 263);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(113, 61);
            btnActualizar.TabIndex = 41;
            btnActualizar.Text = "Editar";
            btnActualizar.TextAlign = ContentAlignment.MiddleRight;
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(549, 19);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(281, 27);
            txtBuscar.TabIndex = 43;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Font = new Font("Arial", 9.75F);
            BtnBuscar.Location = new Point(836, 15);
            BtnBuscar.Margin = new Padding(3, 2, 3, 2);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(108, 34);
            BtnBuscar.TabIndex = 44;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // Clintes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 423);
            Controls.Add(BtnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(btnActualizar);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtDNI);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Clintes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            Load += Clintes_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnGuardar;
        private DataGridView dataGridView1;
        private Label label7;
        private Button btnActualizar;
        private TextBox txtBuscar;
        private Button BtnBuscar;
    }
}