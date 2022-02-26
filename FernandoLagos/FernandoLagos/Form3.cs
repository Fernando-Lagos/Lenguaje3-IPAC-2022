using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FernandoLagos
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string PrimerNombre = NombreTextBox.Text;
            string PrimerApellido = ApellidoTextBox.Text;

            ListaNumeros(PrimerNombre, PrimerApellido);

        }
        private void ListaNumeros(string Nombre, string Apellido)
        { 
            int[] Lista = new int[100];

            for (int i=0; i <=Lista.Length ; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    ResultadoListBox.Items.Add(i + ". Multiplo de 3 y 5 ---- > " + Nombre +" "+Apellido);

                } else if (i % 5 == 0)
                {
                    ResultadoListBox.Items.Add(i + ". Multiplo de 5 ---- > " + Apellido);

                } else if (i % 3 == 0) 
                {
                    ResultadoListBox.Items.Add(i + ". Multiplo de 3 ---- > " + Nombre);
                }
                else
                {
                    ResultadoListBox.Items.Add(i);
                }
                    
            }
        } 

    }
}
