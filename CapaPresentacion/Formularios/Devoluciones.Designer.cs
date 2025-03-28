namespace CapaPresentacion.Formularios
{
    partial class Devoluciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devoluciones));
            label2 = new Label();
            label8 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbVenta = new ComboBox();
            txtMotivo = new TextBox();
            cmbEstado = new ComboBox();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            cmbProducto = new ComboBox();
            label1 = new Label();
            label5 = new Label();
            txtCantidad = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(275, 18);
            label2.Name = "label2";
            label2.Size = new Size(154, 27);
            label2.TabIndex = 26;
            label2.Text = "Devoluciones";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(31, 55);
            label8.Name = "label8";
            label8.Size = new Size(51, 18);
            label8.TabIndex = 27;
            label8.Text = "Venta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 135);
            label3.Name = "label3";
            label3.Size = new Size(61, 18);
            label3.TabIndex = 29;
            label3.Text = "Motivo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(351, 102);
            label4.Name = "label4";
            label4.Size = new Size(61, 18);
            label4.TabIndex = 30;
            label4.Text = "Estado:";
            // 
            // cmbVenta
            // 
            cmbVenta.FormattingEnabled = true;
            cmbVenta.Location = new Point(88, 53);
            cmbVenta.Margin = new Padding(3, 2, 3, 2);
            cmbVenta.Name = "cmbVenta";
            cmbVenta.Size = new Size(248, 23);
            cmbVenta.TabIndex = 31;
            cmbVenta.SelectedIndexChanged += cmbVenta_SelectedIndexChanged;
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(70, 134);
            txtMotivo.Margin = new Padding(3, 2, 3, 2);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(619, 65);
            txtMotivo.TabIndex = 33;
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Producto defectuoso", "Error en la venta", "Cambio de opinión", "Mal estado", "No era el producto correcto" });
            cmbEstado.Location = new Point(428, 99);
            cmbEstado.Margin = new Padding(3, 2, 3, 2);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(251, 23);
            cmbEstado.TabIndex = 34;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(212, 220);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(259, 32);
            btnRegistrar.TabIndex = 35;
            btnRegistrar.Text = "Registrar Devolucion";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(591, 220);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(97, 43);
            btnCancelar.TabIndex = 39;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cmbProducto
            // 
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(428, 53);
            cmbProducto.Margin = new Padding(3, 2, 3, 2);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(251, 23);
            cmbProducto.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(351, 55);
            label1.Name = "label1";
            label1.Size = new Size(77, 18);
            label1.TabIndex = 40;
            label1.Text = "Producto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(7, 99);
            label5.Name = "label5";
            label5.Size = new Size(75, 18);
            label5.TabIndex = 42;
            label5.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(88, 97);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 43;
            txtCantidad.Leave += txtCantidad_Leave;
            // 
            // Devoluciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 292);
            Controls.Add(txtCantidad);
            Controls.Add(label5);
            Controls.Add(cmbProducto);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(cmbEstado);
            Controls.Add(txtMotivo);
            Controls.Add(cmbVenta);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Devoluciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Devoluciones";
            Load += Devoluciones_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label8;
        private Label label3;
        private Label label4;
        private ComboBox cmbVenta;
        private TextBox txtMotivo;
        private ComboBox cmbEstado;
        private Button btnRegistrar;
        private Button btnCancelar;
        private ComboBox cmbProducto;
        private Label label1;
        private Label label5;
        private TextBox txtCantidad;
    }
}