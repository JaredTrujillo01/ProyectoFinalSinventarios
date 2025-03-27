namespace CapaPresentacion.Formularios
{
    partial class MenuVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuVendedor));
            groupBox1 = new GroupBox();
            btnVentas = new Button();
            btnClientes = new Button();
            btnDevoluciones = new Button();
            groupBox2 = new GroupBox();
            btnProductos = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnVentas);
            groupBox1.Controls.Add(btnClientes);
            groupBox1.Controls.Add(btnDevoluciones);
            groupBox1.Location = new Point(15, 32);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(791, 168);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "ACCIONES";
            // 
            // btnVentas
            // 
            btnVentas.Font = new Font("Segoe UI", 8.25F);
            btnVentas.Image = (Image)resources.GetObject("btnVentas.Image");
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(142, 29);
            btnVentas.Margin = new Padding(3, 4, 3, 4);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(169, 104);
            btnVentas.TabIndex = 0;
            btnVentas.Text = "VENTAS";
            btnVentas.TextAlign = ContentAlignment.MiddleRight;
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnClientes
            // 
            btnClientes.Font = new Font("Segoe UI", 8.25F);
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(318, 29);
            btnClientes.Margin = new Padding(3, 4, 3, 4);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(169, 104);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "CLIENTES";
            btnClientes.TextAlign = ContentAlignment.MiddleRight;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnDevoluciones
            // 
            btnDevoluciones.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDevoluciones.Image = (Image)resources.GetObject("btnDevoluciones.Image");
            btnDevoluciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnDevoluciones.Location = new Point(494, 29);
            btnDevoluciones.Margin = new Padding(3, 4, 3, 4);
            btnDevoluciones.Name = "btnDevoluciones";
            btnDevoluciones.Size = new Size(169, 104);
            btnDevoluciones.TabIndex = 2;
            btnDevoluciones.Text = "DEVOLUCIONES";
            btnDevoluciones.TextAlign = ContentAlignment.MiddleRight;
            btnDevoluciones.UseVisualStyleBackColor = true;
            btnDevoluciones.Click += btnDevoluciones_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnProductos);
            groupBox2.Location = new Point(15, 208);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(791, 168);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "CONSULTAR";
            // 
            // btnProductos
            // 
            btnProductos.Font = new Font("Segoe UI", 8.25F);
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(318, 28);
            btnProductos.Margin = new Padding(3, 4, 3, 4);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(169, 104);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "PRODUCTOS";
            btnProductos.TextAlign = ContentAlignment.MiddleRight;
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(661, 382);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(145, 63);
            btnCancelar.TabIndex = 26;
            btnCancelar.Text = "Cerrar Sesión";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // MenuVendedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 456);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MenuVendedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú (Vendedor)";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnVentas;
        private Button btnClientes;
        private Button btnDevoluciones;
        private GroupBox groupBox2;
        private Button btnProductos;
        private Button btnCancelar;
    }
}