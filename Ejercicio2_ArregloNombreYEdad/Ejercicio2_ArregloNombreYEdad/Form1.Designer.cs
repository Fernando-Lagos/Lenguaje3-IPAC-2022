namespace Ejercicio2_ArregloNombreYEdad
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
            this.AlmacenarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreEstudianteTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EdadEstudianteTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DatosAlmacenadosComboBox = new System.Windows.Forms.ComboBox();
            this.MostrarDatosButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AlmacenarButton
            // 
            this.AlmacenarButton.Location = new System.Drawing.Point(28, 125);
            this.AlmacenarButton.Name = "AlmacenarButton";
            this.AlmacenarButton.Size = new System.Drawing.Size(149, 24);
            this.AlmacenarButton.TabIndex = 2;
            this.AlmacenarButton.Text = "Siguiente Registro";
            this.AlmacenarButton.UseVisualStyleBackColor = true;
            this.AlmacenarButton.Click += new System.EventHandler(this.AlmacenarButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese Nombre del Estudiante";
            // 
            // NombreEstudianteTextBox
            // 
            this.NombreEstudianteTextBox.Location = new System.Drawing.Point(183, 47);
            this.NombreEstudianteTextBox.Name = "NombreEstudianteTextBox";
            this.NombreEstudianteTextBox.Size = new System.Drawing.Size(297, 20);
            this.NombreEstudianteTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese Edad del Estudiante";
            // 
            // EdadEstudianteTextBox
            // 
            this.EdadEstudianteTextBox.Location = new System.Drawing.Point(183, 84);
            this.EdadEstudianteTextBox.Name = "EdadEstudianteTextBox";
            this.EdadEstudianteTextBox.Size = new System.Drawing.Size(100, 20);
            this.EdadEstudianteTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(195, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "REGISTRO DE DATOS";
            // 
            // DatosAlmacenadosComboBox
            // 
            this.DatosAlmacenadosComboBox.FormattingEnabled = true;
            this.DatosAlmacenadosComboBox.Location = new System.Drawing.Point(160, 210);
            this.DatosAlmacenadosComboBox.Name = "DatosAlmacenadosComboBox";
            this.DatosAlmacenadosComboBox.Size = new System.Drawing.Size(259, 21);
            this.DatosAlmacenadosComboBox.TabIndex = 8;
            // 
            // MostrarDatosButton
            // 
            this.MostrarDatosButton.Location = new System.Drawing.Point(28, 210);
            this.MostrarDatosButton.Name = "MostrarDatosButton";
            this.MostrarDatosButton.Size = new System.Drawing.Size(96, 21);
            this.MostrarDatosButton.TabIndex = 9;
            this.MostrarDatosButton.Text = "MostrarDatos";
            this.MostrarDatosButton.UseVisualStyleBackColor = true;
            this.MostrarDatosButton.Click += new System.EventHandler(this.MostrarDatosButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "ESTUDIANTES REGISTRADOS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 383);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MostrarDatosButton);
            this.Controls.Add(this.DatosAlmacenadosComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EdadEstudianteTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NombreEstudianteTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AlmacenarButton);
            this.Name = "Form1";
            this.Text = "Registro Estudiantes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AlmacenarButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreEstudianteTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EdadEstudianteTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DatosAlmacenadosComboBox;
        private System.Windows.Forms.Button MostrarDatosButton;
        private System.Windows.Forms.Label label1;
    }
}

