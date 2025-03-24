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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(292, 32);
            label2.TabIndex = 4;
            label2.Text = "Gestion de Categorias";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 41);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 5;
            label3.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(21, 65);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(381, 27);
            txtNombre.TabIndex = 6;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(139, 110);
            button2.Name = "button2";
            button2.Size = new Size(116, 38);
            button2.TabIndex = 20;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(390, 201);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(21, 377);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 40);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Categorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 450);
            Controls.Add(btnEliminar);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Categorias";
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
    }
}