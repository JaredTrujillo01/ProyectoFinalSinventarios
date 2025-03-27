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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            button2 = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(314, 24);
            label2.Name = "label2";
            label2.Size = new Size(179, 32);
            label2.TabIndex = 26;
            label2.Text = "Devoluciones";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(8, 73);
            label8.Name = "label8";
            label8.Size = new Size(67, 21);
            label8.TabIndex = 27;
            label8.Text = "Venta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(389, 77);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 28;
            label1.Text = "Fecha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 123);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 29;
            label3.Text = "Motivo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(8, 165);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 30;
            label4.Text = "Estado:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(81, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(301, 28);
            comboBox1.TabIndex = 31;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(464, 69);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(324, 27);
            dateTimePicker1.TabIndex = 32;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(707, 27);
            textBox1.TabIndex = 33;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(81, 165);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(301, 28);
            comboBox2.TabIndex = 34;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(243, 236);
            button2.Name = "button2";
            button2.Size = new Size(296, 43);
            button2.TabIndex = 35;
            button2.Text = "Registrar Devolucion";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(677, 236);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 57);
            btnCancelar.TabIndex = 39;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Devoluciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 301);
            Controls.Add(btnCancelar);
            Controls.Add(button2);
            Controls.Add(comboBox2);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(label2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Devoluciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Devoluciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label8;
        private Label label1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private Button button2;
        private Button btnCancelar;
    }
}