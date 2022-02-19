namespace Tarea1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PocesarButton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NumeroTextBox1 = new System.Windows.Forms.TextBox();
            this.ParOImparTextBox2 = new System.Windows.Forms.TextBox();
            this.PrimoTextBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PocesarButton1
            // 
            this.PocesarButton1.BackColor = System.Drawing.Color.PowderBlue;
            this.PocesarButton1.Location = new System.Drawing.Point(356, 65);
            this.PocesarButton1.Name = "PocesarButton1";
            this.PocesarButton1.Size = new System.Drawing.Size(75, 23);
            this.PocesarButton1.TabIndex = 0;
            this.PocesarButton1.Text = "Procesar";
            this.PocesarButton1.UseVisualStyleBackColor = false;
            this.PocesarButton1.Click += new System.EventHandler(this.PocesarButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el numero:";
            // 
            // NumeroTextBox1
            // 
            this.NumeroTextBox1.Location = new System.Drawing.Point(231, 65);
            this.NumeroTextBox1.Name = "NumeroTextBox1";
            this.NumeroTextBox1.Size = new System.Drawing.Size(100, 20);
            this.NumeroTextBox1.TabIndex = 2;
            // 
            // ParOImparTextBox2
            // 
            this.ParOImparTextBox2.Location = new System.Drawing.Point(231, 140);
            this.ParOImparTextBox2.Name = "ParOImparTextBox2";
            this.ParOImparTextBox2.Size = new System.Drawing.Size(100, 20);
            this.ParOImparTextBox2.TabIndex = 3;
            // 
            // PrimoTextBox3
            // 
            this.PrimoTextBox3.Location = new System.Drawing.Point(231, 181);
            this.PrimoTextBox3.Name = "PrimoTextBox3";
            this.PrimoTextBox3.Size = new System.Drawing.Size(100, 20);
            this.PrimoTextBox3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "El numero es:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Par o impar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Primo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 257);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrimoTextBox3);
            this.Controls.Add(this.ParOImparTextBox2);
            this.Controls.Add(this.NumeroTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PocesarButton1);
            this.Name = "Form1";
            this.Text = "Numero Par o Impar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PocesarButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumeroTextBox1;
        private System.Windows.Forms.TextBox ParOImparTextBox2;
        private System.Windows.Forms.TextBox PrimoTextBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

