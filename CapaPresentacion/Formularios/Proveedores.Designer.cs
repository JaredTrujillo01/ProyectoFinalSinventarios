namespace CapaPresentacion.Formularios
{
    partial class Proveedores
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
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            btnGuardar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(309, 32);
            label2.TabIndex = 5;
            label2.Text = "Gestion de Proveedores";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 51);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 6;
            label3.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 139);
            label1.Name = "label1";
            label1.Size = new Size(100, 21);
            label1.TabIndex = 7;
            label1.Text = "Direccion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 94);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 8;
            label4.Text = "Telefono:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(118, 49);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(288, 27);
            txtNombre.TabIndex = 9;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(118, 92);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(288, 27);
            txtTelefono.TabIndex = 10;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(118, 137);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(288, 27);
            txtDireccion.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 184);
            label5.Name = "label5";
            label5.Size = new Size(275, 32);
            label5.TabIndex = 12;
            label5.Text = "Lista de Proveedores";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 219);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 219);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(458, 39);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(296, 43);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(458, 88);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(296, 43);
            btnActualizar.TabIndex = 21;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(458, 137);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(296, 43);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar ";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Proveedores";
            Text = "Proveedores";
            Load += Proveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private Label label5;
        private DataGridView dataGridView1;
        private Button btnGuardar;
        private Button btnActualizar;
        private Button btnEliminar;
    }
}