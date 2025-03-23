namespace CapaPresentacion.Formularios
{
    partial class Productos
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtPrecio = new TextBox();
            label5 = new Label();
            txtDesc = new TextBox();
            label6 = new Label();
            txtStock = new TextBox();
            label7 = new Label();
            CBCate = new ComboBox();
            label8 = new Label();
            CBProvee = new ComboBox();
            btnGuardar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 294);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1192, 329);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 254);
            label1.Name = "label1";
            label1.Size = new Size(248, 32);
            label1.TabIndex = 2;
            label1.Text = "Lista de Productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(282, 32);
            label2.TabIndex = 3;
            label2.Text = "Gestion de Productos";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(105, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(281, 27);
            txtNombre.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(401, 57);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 6;
            label4.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(480, 51);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(281, 27);
            txtPrecio.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 106);
            label5.Name = "label5";
            label5.Size = new Size(121, 21);
            label5.TabIndex = 8;
            label5.Text = "Descripcion:";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(139, 104);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(622, 27);
            txtDesc.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 157);
            label6.Name = "label6";
            label6.Size = new Size(66, 21);
            label6.TabIndex = 10;
            label6.Text = "Stock:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(105, 157);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(281, 27);
            txtStock.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(401, 159);
            label7.Name = "label7";
            label7.Size = new Size(101, 21);
            label7.TabIndex = 12;
            label7.Text = "Categoria:";
            // 
            // CBCate
            // 
            CBCate.FormattingEnabled = true;
            CBCate.Location = new Point(508, 157);
            CBCate.Name = "CBCate";
            CBCate.Size = new Size(253, 28);
            CBCate.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 210);
            label8.Name = "label8";
            label8.Size = new Size(109, 21);
            label8.TabIndex = 14;
            label8.Text = "Proveedor:";
            // 
            // CBProvee
            // 
            CBProvee.FormattingEnabled = true;
            CBProvee.Location = new Point(127, 208);
            CBProvee.Name = "CBProvee";
            CBProvee.Size = new Size(375, 28);
            CBProvee.TabIndex = 15;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(848, 51);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(296, 43);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(848, 119);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(296, 43);
            btnActualizar.TabIndex = 20;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(848, 193);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(296, 43);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar ";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 57);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 22;
            label3.Text = "Nombre:";
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 631);
            Controls.Add(label3);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(CBProvee);
            Controls.Add(label8);
            Controls.Add(CBCate);
            Controls.Add(label7);
            Controls.Add(txtStock);
            Controls.Add(label6);
            Controls.Add(txtDesc);
            Controls.Add(label5);
            Controls.Add(txtPrecio);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Productos";
            Text = "Productos";
            Load += Productos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtPrecio;
        private Label label5;
        private TextBox txtDesc;
        private Label label6;
        private TextBox txtStock;
        private Label label7;
        private ComboBox CBCate;
        private Label label8;
        private ComboBox CBProvee;
        private Button btnGuardar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Label label3;
    }
}