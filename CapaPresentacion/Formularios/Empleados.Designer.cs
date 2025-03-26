namespace CapaPresentacion.Formularios
{
    partial class Empleados
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
            btnCancelar = new Button();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            txtBuscar = new TextBox();
            BtnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Arial", 9.75F);
            btnCancelar.Location = new Point(876, 9);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 28);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(972, 392);
            dataGridView1.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(259, 32);
            label7.TabIndex = 41;
            label7.Text = "Lista de Empleados";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(277, 15);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(281, 27);
            txtBuscar.TabIndex = 42;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Font = new Font("Arial", 9.75F);
            BtnBuscar.Location = new Point(564, 15);
            BtnBuscar.Margin = new Padding(3, 2, 3, 2);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(108, 28);
            BtnBuscar.TabIndex = 43;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 450);
            Controls.Add(BtnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(btnCancelar);
            Name = "Empleados";
            Text = "Empleados";
            Load += Empleados_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private DataGridView dataGridView1;
        private Label label7;
        private TextBox txtBuscar;
        private Button BtnBuscar;
    }
}