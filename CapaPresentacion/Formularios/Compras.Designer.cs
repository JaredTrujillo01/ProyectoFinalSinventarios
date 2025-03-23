namespace CapaPresentacion.Formularios
{
    partial class Compras
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
            label8 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            Productos = new DataGridViewComboBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            label3 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(303, 21);
            label2.Name = "label2";
            label2.Size = new Size(195, 32);
            label2.TabIndex = 6;
            label2.Text = "Nueva Compra";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 75);
            label8.Name = "label8";
            label8.Size = new Size(109, 21);
            label8.TabIndex = 15;
            label8.Text = "Proveedor:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(127, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(261, 28);
            comboBox1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(394, 75);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 17;
            label1.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(470, 75);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(312, 27);
            dateTimePicker1.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Productos, Cantidad, PrecioCompra, Subtotal });
            dataGridView1.Location = new Point(12, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(770, 188);
            dataGridView1.TabIndex = 19;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 325);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 20;
            label3.Text = "Total:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 323);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 27);
            textBox1.TabIndex = 21;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(570, 315);
            button2.Name = "button2";
            button2.Size = new Size(212, 40);
            button2.TabIndex = 22;
            button2.Text = "Agregar Producto";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(352, 314);
            button1.Name = "button1";
            button1.Size = new Size(212, 40);
            button1.TabIndex = 23;
            button1.Text = "Eliminar Producto";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(286, 394);
            button3.Name = "button3";
            button3.Size = new Size(212, 40);
            button3.TabIndex = 24;
            button3.Text = "Realizar Compra";
            button3.UseVisualStyleBackColor = true;
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 457);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(label2);
            Name = "Compras";
            Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label8;
        private ComboBox comboBox1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private DataGridViewComboBoxColumn Productos;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn Subtotal;
        private Label label3;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private Button button3;
    }
}