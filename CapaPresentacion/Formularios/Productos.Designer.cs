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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
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
            btnCancelar = new Button();
            txtBuscar = new TextBox();
            BtnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 252);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(902, 247);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 226);
            label1.Name = "label1";
            label1.Size = new Size(139, 18);
            label1.TabIndex = 2;
            label1.Text = "Lista de Productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 7);
            label2.Name = "label2";
            label2.Size = new Size(238, 27);
            label2.TabIndex = 3;
            label2.Text = "Gestion de Productos";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(110, 41);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(236, 23);
            txtNombre.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.8F);
            label4.Location = new Point(351, 43);
            label4.Name = "label4";
            label4.Size = new Size(54, 17);
            label4.TabIndex = 6;
            label4.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(420, 38);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(246, 23);
            txtPrecio.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.8F);
            label5.Location = new Point(10, 80);
            label5.Name = "label5";
            label5.Size = new Size(90, 17);
            label5.TabIndex = 8;
            label5.Text = "Descripcion:";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(110, 78);
            txtDesc.Margin = new Padding(3, 2, 3, 2);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(556, 55);
            txtDesc.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.8F);
            label6.Location = new Point(46, 145);
            label6.Name = "label6";
            label6.Size = new Size(49, 17);
            label6.TabIndex = 10;
            label6.Text = "Stock:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(110, 143);
            txtStock.Margin = new Padding(3, 2, 3, 2);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(236, 23);
            txtStock.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.8F);
            label7.Location = new Point(354, 145);
            label7.Name = "label7";
            label7.Size = new Size(75, 17);
            label7.TabIndex = 12;
            label7.Text = "Categoria:";
            // 
            // CBCate
            // 
            CBCate.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCate.FormattingEnabled = true;
            CBCate.Location = new Point(446, 143);
            CBCate.Margin = new Padding(3, 2, 3, 2);
            CBCate.Name = "CBCate";
            CBCate.Size = new Size(222, 23);
            CBCate.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10.8F);
            label8.Location = new Point(19, 184);
            label8.Name = "label8";
            label8.Size = new Size(79, 17);
            label8.TabIndex = 14;
            label8.Text = "Proveedor:";
            // 
            // CBProvee
            // 
            CBProvee.DropDownStyle = ComboBoxStyle.DropDownList;
            CBProvee.FormattingEnabled = true;
            CBProvee.Location = new Point(110, 182);
            CBProvee.Margin = new Padding(3, 2, 3, 2);
            CBProvee.Name = "CBProvee";
            CBProvee.Size = new Size(332, 23);
            CBProvee.TabIndex = 15;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(751, 49);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 38);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Image = (Image)resources.GetObject("btnActualizar.Image");
            btnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizar.Location = new Point(751, 92);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(100, 38);
            btnActualizar.TabIndex = 20;
            btnActualizar.Text = "Editar";
            btnActualizar.TextAlign = ContentAlignment.MiddleRight;
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(751, 133);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 40);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar ";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F);
            label3.Location = new Point(30, 43);
            label3.Name = "label3";
            label3.Size = new Size(64, 17);
            label3.TabIndex = 22;
            label3.Text = "Nombre:";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(751, 182);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 40);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(169, 227);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(307, 23);
            txtBuscar.TabIndex = 24;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Font = new Font("Arial", 9.75F);
            BtnBuscar.Location = new Point(480, 224);
            BtnBuscar.Margin = new Padding(3, 2, 3, 2);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(94, 26);
            BtnBuscar.TabIndex = 25;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 506);
            Controls.Add(BtnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(btnCancelar);
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
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Productos";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button btnCancelar;
        private TextBox txtBuscar;
        private Button BtnBuscar;
    }
}