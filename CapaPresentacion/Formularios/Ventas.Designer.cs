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
            btnRealizarVenta = new Button();
            btnEliminarP = new Button();
            txtTotal = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            dtpFecha = new DateTimePicker();
            label1 = new Label();
            cmbCliente = new ComboBox();
            label8 = new Label();
            label2 = new Label();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnRealizarVenta
            // 
            btnRealizarVenta.Font = new Font("Arial", 8.25F);
            btnRealizarVenta.Image = (Image)resources.GetObject("btnRealizarVenta.Image");
            btnRealizarVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnRealizarVenta.Location = new Point(16, 284);
            btnRealizarVenta.Margin = new Padding(3, 2, 3, 2);
            btnRealizarVenta.Name = "btnRealizarVenta";
            btnRealizarVenta.Size = new Size(188, 43);
            btnRealizarVenta.TabIndex = 35;
            btnRealizarVenta.Text = "Realizar Venta";
            btnRealizarVenta.TextAlign = ContentAlignment.MiddleRight;
            btnRealizarVenta.UseVisualStyleBackColor = true;
            btnRealizarVenta.Click += btnRealizarVenta_Click;
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
            btnEliminarP.Click += btnEliminarP_Click;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(70, 241);
            txtTotal.Margin = new Padding(3, 2, 3, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(134, 23);
            txtTotal.TabIndex = 32;
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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 88);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(674, 141);
            dataGridView1.TabIndex = 30;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(414, 55);
            dtpFecha.Margin = new Padding(3, 2, 3, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(274, 23);
            dtpFecha.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(347, 55);
            label1.Name = "label1";
            label1.Size = new Size(53, 17);
            label1.TabIndex = 28;
            label1.Text = "Fecha:";
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(88, 53);
            cmbCliente.Margin = new Padding(3, 2, 3, 2);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(255, 23);
            cmbCliente.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(13, 55);
            label8.Name = "label8";
            label8.Size = new Size(57, 17);
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
            Controls.Add(btnRealizarVenta);
            Controls.Add(btnEliminarP);
            Controls.Add(txtTotal);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(dtpFecha);
            Controls.Add(label1);
            Controls.Add(cmbCliente);
            Controls.Add(label8);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Ventas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventas";
            Load += Ventas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRealizarVenta;
        private Button btnEliminarP;
        private TextBox txtTotal;
        private Label label3;
        private DataGridView dataGridView1;
        private DateTimePicker dtpFecha;
        private Label label1;
        private ComboBox cmbCliente;
        private Label label8;
        private Label label2;
        private Button btnCancelar;
    }
}