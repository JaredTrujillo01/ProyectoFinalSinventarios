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
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnVentas);
            groupBox1.Controls.Add(btnClientes);
            groupBox1.Controls.Add(btnDevoluciones);
            groupBox1.Location = new Point(12, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(692, 126);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "ACCIONES";
            // 
            // btnVentas
            // 
            btnVentas.Font = new Font("Segoe UI", 8.25F);
            btnVentas.Image = (Image)resources.GetObject("btnVentas.Image");
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(124, 22);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(148, 78);
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
            btnClientes.Location = new Point(278, 22);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(148, 78);
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
            btnDevoluciones.Location = new Point(432, 22);
            btnDevoluciones.Name = "btnDevoluciones";
            btnDevoluciones.Size = new Size(148, 78);
            btnDevoluciones.TabIndex = 2;
            btnDevoluciones.Text = "DEVOLUCIONES";
            btnDevoluciones.TextAlign = ContentAlignment.MiddleRight;
            btnDevoluciones.UseVisualStyleBackColor = true;
            btnDevoluciones.Click += btnDevoluciones_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnProductos);
            groupBox2.Location = new Point(12, 182);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(692, 126);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "CONSULTAR";
            // 
            // btnProductos
            // 
            btnProductos.Font = new Font("Segoe UI", 8.25F);
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(297, 22);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(148, 78);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "PRODUCTOS";
            btnProductos.TextAlign = ContentAlignment.MiddleRight;
            btnProductos.UseVisualStyleBackColor = true;
            // 
            // MenuVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 320);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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
    }
}