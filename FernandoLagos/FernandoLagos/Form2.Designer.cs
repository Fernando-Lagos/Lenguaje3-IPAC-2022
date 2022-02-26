namespace FernandoLagos
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductoTextBox = new System.Windows.Forms.TextBox();
            this.PrecioTextBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DescuentoTextBox = new System.Windows.Forms.TextBox();
            this.TotalAPagarTextBox = new System.Windows.Forms.TextBox();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCTO: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PRECIO UNITARIO:";
            // 
            // ProductoTextBox
            // 
            this.ProductoTextBox.Location = new System.Drawing.Point(176, 32);
            this.ProductoTextBox.Name = "ProductoTextBox";
            this.ProductoTextBox.Size = new System.Drawing.Size(169, 20);
            this.ProductoTextBox.TabIndex = 2;
            // 
            // PrecioTextBox2
            // 
            this.PrecioTextBox2.Location = new System.Drawing.Point(176, 73);
            this.PrecioTextBox2.Name = "PrecioTextBox2";
            this.PrecioTextBox2.Size = new System.Drawing.Size(169, 20);
            this.PrecioTextBox2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CalcularButton);
            this.groupBox1.Controls.Add(this.PrecioTextBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ProductoTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 143);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "DESCUENTO OBTENIDO: \r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "TOTAL A PAGAR: ";
            // 
            // DescuentoTextBox
            // 
            this.DescuentoTextBox.Location = new System.Drawing.Point(166, 171);
            this.DescuentoTextBox.Name = "DescuentoTextBox";
            this.DescuentoTextBox.Size = new System.Drawing.Size(143, 20);
            this.DescuentoTextBox.TabIndex = 7;
            // 
            // TotalAPagarTextBox
            // 
            this.TotalAPagarTextBox.Location = new System.Drawing.Point(166, 205);
            this.TotalAPagarTextBox.Name = "TotalAPagarTextBox";
            this.TotalAPagarTextBox.Size = new System.Drawing.Size(143, 20);
            this.TotalAPagarTextBox.TabIndex = 8;
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(374, 49);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(117, 37);
            this.CalcularButton.TabIndex = 4;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 268);
            this.Controls.Add(this.TotalAPagarTextBox);
            this.Controls.Add(this.DescuentoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Ejercicio 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProductoTextBox;
        private System.Windows.Forms.TextBox PrecioTextBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DescuentoTextBox;
        private System.Windows.Forms.TextBox TotalAPagarTextBox;
        private System.Windows.Forms.Button CalcularButton;
    }
}