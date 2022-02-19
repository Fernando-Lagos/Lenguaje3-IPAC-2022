using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2_ArregloNombreYEdad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int Tamanio = 4;
        string[] nombre = new string[Tamanio];
        int[] edad = new int[Tamanio];
        static int Contador = -1;
        private void AlmacenarButton_Click(object sender, EventArgs e)
        {
            Contador = Contador + 1;
            if (Contador < nombre.Length)
            {
                nombre[Contador] = NombreEstudianteTextBox.Text;
                edad[Contador] = Convert.ToInt32(EdadEstudianteTextBox.Text);
                NombreEstudianteTextBox.Text = "";
                EdadEstudianteTextBox.Text = "";
            }
            if(Contador==3)
            {
                MessageBox.Show("A alcanzado el numero maximo de registros permitidos", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
               
        }
        private void MostrarDatosButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nombre.Length; i++)
            {
                DatosAlmacenadosComboBox.Items.Add( nombre[i] +", "+edad[i]+" Años");
            }
        }
    }
}
