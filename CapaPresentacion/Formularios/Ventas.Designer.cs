namespace CapaPresentacion.Formularios
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            button3 = new Button();
            btnEliminarP = new Button();
            btnAgregarP = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Productos = new DataGridViewComboBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label8 = new Label();
            label2 = new Label();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 8.25F);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(16, 284);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(188, 43);
            button3.TabIndex = 35;
            button3.Text = "Realizar Venta";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = true;
            // 
            // btnEliminarP
            // 
            btnEliminarP.Font = new Font("Arial", 8.25F);
            btnEliminarP.Image = (Image)resources.GetObject("btnEliminarP.Image");
            btnEliminarP.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarP.Location = new Point(476, 256);
            btnEliminarP.Margin = new Padding(3, 2, 3, 2);
            btnEliminarP.Name = "btnEliminarP";
            btnEliminarP.Size = new Size(97, 46);
            btnEliminarP.TabIndex = 34;
            btnEliminarP.Text = "Eliminar P";
            btnEliminarP.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarP.UseVisualStyleBackColor = true;
            // 
            // btnAgregarP
            // 
            btnAgregarP.Font = new Font("Arial", 8.25F);
            btnAgregarP.Image = (Image)resources.GetObject("btnAgregarP.Image");
            btnAgregarP.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarP.Location = new Point(359, 256);
            btnAgregarP.Margin = new Padding(3, 2, 3, 2);
            btnAgregarP.Name = "btnAgregarP";
            btnAgregarP.Size = new Size(97, 46);
            btnAgregarP.TabIndex = 33;
            btnAgregarP.Text = "Agregar P";
            btnAgregarP.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarP.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(70, 241);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 23);
            textBox1.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 242);
            label3.Name = "label3";
            label3.Size = new Size(47, 18);
            label3.TabIndex = 31;
            label3.Text = "Total:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Productos, Cantidad, PrecioCompra, Subtotal });
            dataGridView1.Location = new Point(13, 88);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(674, 141);
            dataGridView1.TabIndex = 30;
            // 
            // Productos
            // 
            Productos.HeaderText = "Producto";
            Productos.MinimumWidth = 6;
            Productos.Name = "Productos";
            Productos.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 125;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio";
            PrecioCompra.MinimumWidth = 6;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.Width = 125;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.Width = 125;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(414, 55);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(274, 23);
            dateTimePicker1.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(347, 55);
            label1.Name = "label1";
            label1.Size = new Size(55, 18);
            label1.TabIndex = 28;
            label1.Text = "Fecha:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(88, 53);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(255, 23);
            comboBox1.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(13, 55);
            label8.Name = "label8";
            label8.Size = new Size(63, 18);
            label8.TabIndex = 26;
            label8.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(268, 14);
            label2.Name = "label2";
            label2.Size = new Size(146, 27);
            label2.TabIndex = 25;
            label2.Text = "Nueva Venta";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(590, 255);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(97, 46);
            btnCancelar.TabIndex = 39;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnCancelar);
            Controls.Add(button3);
            Controls.Add(btnEliminarP);
            Controls.Add(btnAgregarP);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Ventas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button btnEliminarP;
        private Button btnAgregarP;
        private TextBox textBox1;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewComboBoxColumn Productos;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn Subtotal;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label8;
        private Label label2;
        private Button btnCancelar;
    }
}