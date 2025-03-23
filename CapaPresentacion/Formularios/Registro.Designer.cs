namespace CapaPresentacion.Formularios
{
    partial class Registro
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
            label1 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(234, 17);
            label1.Name = "label1";
            label1.Size = new Size(354, 40);
            label1.TabIndex = 1;
            label1.Text = "Registro de Empleado";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(171, 112);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(472, 27);
            textBox3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(171, 81);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 8;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(171, 150);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 9;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(171, 221);
            label4.Name = "label4";
            label4.Size = new Size(96, 28);
            label4.TabIndex = 10;
            label4.Text = "Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(171, 292);
            label5.Name = "label5";
            label5.Size = new Size(143, 28);
            label5.TabIndex = 11;
            label5.Text = "Contraseña:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(171, 181);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(472, 27);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(171, 252);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(472, 27);
            textBox2.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(171, 323);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(472, 27);
            textBox4.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(171, 363);
            label6.Name = "label6";
            label6.Size = new Size(83, 28);
            label6.TabIndex = 15;
            label6.Text = "Cargo:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(171, 393);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(472, 28);
            comboBox1.TabIndex = 16;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(307, 451);
            button1.Name = "button1";
            button1.Size = new Size(152, 43);
            button1.TabIndex = 17;
            button1.Text = "Registrarse ";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 511);
            button2.Name = "button2";
            button2.Size = new Size(118, 43);
            button2.TabIndex = 18;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 566);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Name = "Registro";
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private Label label6;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
    }
}