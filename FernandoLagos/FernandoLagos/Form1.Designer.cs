namespace FernandoLagos
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
            this.CalcularButton1 = new System.Windows.Forms.Button();
            this.MostrarDatosListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CapitalTextBox = new System.Windows.Forms.TextBox();
            this.TasaInteresTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FechaDepositoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // CalcularButton1
            // 
            this.CalcularButton1.Location = new System.Drawing.Point(455, 75);
            this.CalcularButton1.Name = "CalcularButton1";
            this.CalcularButton1.Size = new System.Drawing.Size(95, 32);
            this.CalcularButton1.TabIndex = 0;
            this.CalcularButton1.Text = "Calcular";
            this.CalcularButton1.UseVisualStyleBackColor = true;
            this.CalcularButton1.Click += new System.EventHandler(this.CalcularButton1_Click);
            // 
            // MostrarDatosListBox
            // 
            this.MostrarDatosListBox.FormattingEnabled = true;
            this.MostrarDatosListBox.Location = new System.Drawing.Point(37, 148);
            this.MostrarDatosListBox.Name = "MostrarDatosListBox";
            this.MostrarDatosListBox.Size = new System.Drawing.Size(568, 147);
            this.MostrarDatosListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CAPITAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "TASA DE INTÉRES";
            // 
            // CapitalTextBox
            // 
            this.CapitalTextBox.Location = new System.Drawing.Point(164, 16);
            this.CapitalTextBox.Name = "CapitalTextBox";
            this.CapitalTextBox.Size = new System.Drawing.Size(100, 20);
            this.CapitalTextBox.TabIndex = 4;
            // 
            // TasaInteresTextBox
            // 
            this.TasaInteresTextBox.Location = new System.Drawing.Point(164, 82);
            this.TasaInteresTextBox.Name = "TasaInteresTextBox";
            this.TasaInteresTextBox.ReadOnly = true;
            this.TasaInteresTextBox.Size = new System.Drawing.Size(100, 20);
            this.TasaInteresTextBox.TabIndex = 5;
            this.TasaInteresTextBox.Text = "2.5%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "INTERESES MENSUALES GENERADOS: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "FECHA DEL DEPOSITO";
            // 
            // FechaDepositoDateTimePicker
            // 
            this.FechaDepositoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDepositoDateTimePicker.Location = new System.Drawing.Point(164, 46);
            this.FechaDepositoDateTimePicker.Name = "FechaDepositoDateTimePicker";
            this.FechaDepositoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.FechaDepositoDateTimePicker.TabIndex = 8;
            this.FechaDepositoDateTimePicker.Value = new System.DateTime(2022, 1, 1, 15, 27, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 307);
            this.Controls.Add(this.FechaDepositoDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TasaInteresTextBox);
            this.Controls.Add(this.CapitalTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MostrarDatosListBox);
            this.Controls.Add(this.CalcularButton1);
            this.Name = "Form1";
            this.Text = "Ejercicio 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcularButton1;
        private System.Windows.Forms.ListBox MostrarDatosListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CapitalTextBox;
        private System.Windows.Forms.TextBox TasaInteresTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker FechaDepositoDateTimePicker;
    }
}

