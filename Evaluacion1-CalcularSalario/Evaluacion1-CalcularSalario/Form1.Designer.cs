namespace Evaluacion1_CalcularSalario
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
            this.FechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaInicioDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SalarioTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PromedioVentasTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SalarioNuevoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FechaNacimientoDateTimePicker
            // 
            this.FechaNacimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaNacimientoDateTimePicker.Location = new System.Drawing.Point(416, 68);
            this.FechaNacimientoDateTimePicker.Name = "FechaNacimientoDateTimePicker";
            this.FechaNacimientoDateTimePicker.Size = new System.Drawing.Size(117, 20);
            this.FechaNacimientoDateTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "INGRESE SU FECHA DE NACIMIENTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "INGRESE LA FECHA EN QUE EMPEZO A LABORAR";
            // 
            // FechaInicioDateTimePicker1
            // 
            this.FechaInicioDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaInicioDateTimePicker1.Location = new System.Drawing.Point(416, 97);
            this.FechaInicioDateTimePicker1.Name = "FechaInicioDateTimePicker1";
            this.FechaInicioDateTimePicker1.Size = new System.Drawing.Size(117, 20);
            this.FechaInicioDateTimePicker1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "INGRESE SU SALARIO BASE";
            // 
            // SalarioTextBox
            // 
            this.SalarioTextBox.Location = new System.Drawing.Point(416, 40);
            this.SalarioTextBox.Name = "SalarioTextBox";
            this.SalarioTextBox.Size = new System.Drawing.Size(117, 20);
            this.SalarioTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(332, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "INGRESE EL MONTO DE SUS VENTAS PROMEDIO";
            // 
            // PromedioVentasTextBox
            // 
            this.PromedioVentasTextBox.Location = new System.Drawing.Point(416, 128);
            this.PromedioVentasTextBox.Name = "PromedioVentasTextBox";
            this.PromedioVentasTextBox.Size = new System.Drawing.Size(117, 20);
            this.PromedioVentasTextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "SALARIO NUEVO: ";
            // 
            // SalarioNuevoTextBox
            // 
            this.SalarioNuevoTextBox.Location = new System.Drawing.Point(166, 242);
            this.SalarioNuevoTextBox.Name = "SalarioNuevoTextBox";
            this.SalarioNuevoTextBox.Size = new System.Drawing.Size(100, 20);
            this.SalarioNuevoTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 301);
            this.Controls.Add(this.SalarioNuevoTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PromedioVentasTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SalarioTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FechaInicioDateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechaNacimientoDateTimePicker);
            this.Name = "Form1";
            this.Text = "Calcular Salario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker FechaNacimientoDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FechaInicioDateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SalarioTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PromedioVentasTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SalarioNuevoTextBox;
    }
}

