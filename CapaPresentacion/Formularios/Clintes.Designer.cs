namespace CapaPresentacion.Formularios
{
    partial class Clintes
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
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Arial", 9.75F);
            btnCancelar.Location = new Point(680, 11);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 28);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 6);
            label2.Name = "label2";
            label2.Size = new Size(259, 32);
            label2.TabIndex = 25;
            label2.Text = "Gestion de Clientes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 51);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 26;
            label3.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 87);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 27;
            label1.Text = "Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 122);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 28;
            label4.Text = "DNI:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 159);
            label5.Name = "label5";
            label5.Size = new Size(100, 21);
            label5.TabIndex = 29;
            label5.Text = "Direccion:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 199);
            label6.Name = "label6";
            label6.Size = new Size(82, 21);
            label6.TabIndex = 30;
            label6.Text = "Correo: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(118, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 27);
            textBox1.TabIndex = 31;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(118, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(289, 27);
            textBox2.TabIndex = 32;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(118, 120);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(289, 27);
            textBox3.TabIndex = 33;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(118, 157);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(289, 27);
            textBox4.TabIndex = 34;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(118, 193);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(289, 27);
            textBox5.TabIndex = 35;
            // 
            // Clintes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Name = "Clintes";
            Text = "Clintes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}