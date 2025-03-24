namespace CapaPresentacion.Formularios
{
    partial class MenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdmin));
            btnProductos = new Button();
            btnProveedores = new Button();
            btnCompras = new Button();
            btnCategorías = new Button();
            btnRVentas = new Button();
            btnRProveedores = new Button();
            btnRProductos = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnProductos
            // 
            btnProductos.Font = new Font("Segoe UI", 8.25F);
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(34, 30);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(148, 78);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "PRODUCTOS";
            btnProductos.TextAlign = ContentAlignment.MiddleRight;
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.Font = new Font("Segoe UI", 8.25F);
            btnProveedores.Image = (Image)resources.GetObject("btnProveedores.Image");
            btnProveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnProveedores.Location = new Point(188, 30);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(148, 78);
            btnProveedores.TabIndex = 1;
            btnProveedores.Text = "PROVEEDORES";
            btnProveedores.TextAlign = ContentAlignment.MiddleRight;
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnCompras
            // 
            btnCompras.Font = new Font("Segoe UI", 8.25F);
            btnCompras.Image = (Image)resources.GetObject("btnCompras.Image");
            btnCompras.ImageAlign = ContentAlignment.MiddleLeft;
            btnCompras.Location = new Point(342, 30);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(148, 78);
            btnCompras.TabIndex = 2;
            btnCompras.Text = "COMPRAS";
            btnCompras.TextAlign = ContentAlignment.MiddleRight;
            btnCompras.UseVisualStyleBackColor = true;
            btnCompras.Click += btnCompras_Click;
            // 
            // btnCategorías
            // 
            btnCategorías.Font = new Font("Segoe UI", 8.25F);
            btnCategorías.Image = (Image)resources.GetObject("btnCategorías.Image");
            btnCategorías.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategorías.Location = new Point(496, 30);
            btnCategorías.Name = "btnCategorías";
            btnCategorías.Size = new Size(148, 78);
            btnCategorías.TabIndex = 3;
            btnCategorías.Text = "CATEGORÍAS";
            btnCategorías.TextAlign = ContentAlignment.MiddleRight;
            btnCategorías.UseVisualStyleBackColor = true;
            btnCategorías.Click += btnCategorías_Click;
            // 
            // btnRVentas
            // 
            btnRVentas.Font = new Font("Segoe UI", 8.25F);
            btnRVentas.Image = (Image)resources.GetObject("btnRVentas.Image");
            btnRVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnRVentas.Location = new Point(127, 42);
            btnRVentas.Name = "btnRVentas";
            btnRVentas.Size = new Size(148, 72);
            btnRVentas.TabIndex = 4;
            btnRVentas.Text = "R_VENTAS";
            btnRVentas.TextAlign = ContentAlignment.MiddleRight;
            btnRVentas.UseVisualStyleBackColor = true;
            // 
            // btnRProveedores
            // 
            btnRProveedores.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRProveedores.Image = (Image)resources.GetObject("btnRProveedores.Image");
            btnRProveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnRProveedores.Location = new Point(281, 42);
            btnRProveedores.Name = "btnRProveedores";
            btnRProveedores.Size = new Size(148, 72);
            btnRProveedores.TabIndex = 5;
            btnRProveedores.Text = "R_PROVEEDORES";
            btnRProveedores.TextAlign = ContentAlignment.MiddleRight;
            btnRProveedores.UseVisualStyleBackColor = true;
            // 
            // btnRProductos
            // 
            btnRProductos.Font = new Font("Segoe UI", 8.25F);
            btnRProductos.Image = (Image)resources.GetObject("btnRProductos.Image");
            btnRProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnRProductos.Location = new Point(435, 42);
            btnRProductos.Name = "btnRProductos";
            btnRProductos.Size = new Size(148, 72);
            btnRProductos.TabIndex = 6;
            btnRProductos.Text = "R_PRODUCTOS";
            btnRProductos.TextAlign = ContentAlignment.MiddleRight;
            btnRProductos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnProductos);
            groupBox1.Controls.Add(btnProveedores);
            groupBox1.Controls.Add(btnCompras);
            groupBox1.Controls.Add(btnCategorías);
            groupBox1.Location = new Point(12, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(692, 126);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "ACCIONES";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRProveedores);
            groupBox2.Controls.Add(btnRVentas);
            groupBox2.Controls.Add(btnRProductos);
            groupBox2.Location = new Point(12, 235);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(692, 130);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "REPORTES";
            // 
            // MenuAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 394);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MenuAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú (Administrador)";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnProductos;
        private Button btnProveedores;
        private Button btnCompras;
        private Button btnCategorías;
        private Button btnRVentas;
        private Button btnRProveedores;
        private Button btnRProductos;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}