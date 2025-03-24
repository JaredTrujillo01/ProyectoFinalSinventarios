namespace CapaPresentacion.Formularios
{
    partial class Categorias
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
            label3 = new Label();
            txtNombre = new TextBox();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            btnEliminar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 9);
            label2.Name = "label2";
            label2.Size = new Size(292, 32);
            label2.TabIndex = 4;
            label2.Text = "Gestion de Categorias";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(83, 22);
            label3.TabIndex = 5;
            label3.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(86, 66);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(221, 26);
            txtNombre.TabIndex = 6;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(327, 144);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(87, 41);
            button2.TabIndex = 20;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 111);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(292, 171);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(327, 189);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(87, 43);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Arial", 9.75F);
            btnCancelar.Location = new Point(351, 265);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(74, 28);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Categorias
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 293);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Categorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categorias";
            Load += Categorias_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private Button button2;
        private DataGridView dataGridView1;
        private Button btnEliminar;
        private Button btnCancelar;
    }
}