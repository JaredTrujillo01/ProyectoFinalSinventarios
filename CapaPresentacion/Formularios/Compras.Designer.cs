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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras));
            label2 = new Label();
            label8 = new Label();
            cmbProveedores = new ComboBox();
            label1 = new Label();
            dtpFechaCompra = new DateTimePicker();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            txtTotal = new TextBox();
            btnRealizarCompra = new Button();
            btnCancelar = new Button();
            btnEliminarP = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(265, 16);
            label2.Name = "label2";
            label2.Size = new Size(166, 27);
            label2.TabIndex = 6;
            label2.Text = "Nueva Compra";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 11.25F);
            label8.Location = new Point(10, 56);
            label8.Name = "label8";
            label8.Size = new Size(79, 17);
            label8.TabIndex = 15;
            label8.Text = "Proveedor:";
            // 
            // cmbProveedores
            // 
            cmbProveedores.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProveedores.FormattingEnabled = true;
            cmbProveedores.Location = new Point(111, 55);
            cmbProveedores.Margin = new Padding(3, 2, 3, 2);
            cmbProveedores.Name = "cmbProveedores";
            cmbProveedores.Size = new Size(229, 23);
            cmbProveedores.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F);
            label1.Location = new Point(345, 56);
            label1.Name = "label1";
            label1.Size = new Size(53, 17);
            label1.TabIndex = 17;
            label1.Text = "Fecha:";
            // 
            // dtpFechaCompra
            // 
            dtpFechaCompra.Location = new Point(411, 56);
            dtpFechaCompra.Margin = new Padding(3, 2, 3, 2);
            dtpFechaCompra.Name = "dtpFechaCompra";
            dtpFechaCompra.Size = new Size(274, 23);
            dtpFechaCompra.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 90);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(674, 141);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 244);
            label3.Name = "label3";
            label3.Size = new Size(47, 18);
            label3.TabIndex = 20;
            label3.Text = "Total:";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(67, 242);
            txtTotal.Margin = new Padding(3, 2, 3, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(134, 23);
            txtTotal.TabIndex = 21;
            // 
            // btnRealizarCompra
            // 
            btnRealizarCompra.Font = new Font("Arial", 8.25F);
            btnRealizarCompra.Image = (Image)resources.GetObject("btnRealizarCompra.Image");
            btnRealizarCompra.ImageAlign = ContentAlignment.MiddleLeft;
            btnRealizarCompra.Location = new Point(13, 285);
            btnRealizarCompra.Margin = new Padding(3, 2, 3, 2);
            btnRealizarCompra.Name = "btnRealizarCompra";
            btnRealizarCompra.Size = new Size(188, 43);
            btnRealizarCompra.TabIndex = 42;
            btnRealizarCompra.Text = "Realizar Compra";
            btnRealizarCompra.TextAlign = ContentAlignment.MiddleRight;
            btnRealizarCompra.UseVisualStyleBackColor = true;
            btnRealizarCompra.Click += btnRealizarCompra_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(562, 272);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(97, 46);
            btnCancelar.TabIndex = 45;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_2;
            // 
            // btnEliminarP
            // 
            btnEliminarP.Font = new Font("Arial", 8.25F);
            btnEliminarP.Image = (Image)resources.GetObject("btnEliminarP.Image");
            btnEliminarP.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarP.Location = new Point(448, 273);
            btnEliminarP.Margin = new Padding(3, 2, 3, 2);
            btnEliminarP.Name = "btnEliminarP";
            btnEliminarP.Size = new Size(97, 46);
            btnEliminarP.TabIndex = 44;
            btnEliminarP.Text = "Eliminar P";
            btnEliminarP.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarP.UseVisualStyleBackColor = true;
            btnEliminarP.Click += btnEliminarP_Click;
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 343);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminarP);
            Controls.Add(btnRealizarCompra);
            Controls.Add(txtTotal);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(dtpFechaCompra);
            Controls.Add(label1);
            Controls.Add(cmbProveedores);
            Controls.Add(label8);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Compras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compras";
            Load += Compras_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label8;
        private ComboBox cmbProveedores;
        private Label label1;
        private DateTimePicker dtpFechaCompra;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox txtTotal;
        private Button btnRealizarCompra;
        private Button btnCancelar;
        private Button btnEliminarP;
    }
}