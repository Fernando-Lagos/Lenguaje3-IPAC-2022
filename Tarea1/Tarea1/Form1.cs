using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PocesarButton1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(NumeroTextBox1.Text);

            ParOImparTextBox2.Text = ParOImpar(num1).ToString();
            PrimoTextBox3.Text = Primo(num1).ToString();
        }


        private string ParOImpar(int num1)
        {
            string resultado;
            if ((num1 % 2) == 0)
            {
                resultado = "Par";
            }
            else
                resultado = "Impar";
            return resultado;
        }

        private string Primo(int num1)
        {
            int x = num1;
            string resultado = "Si";

            for (int i = 2; i < x; i++)       
            {
                if (x%i==0) 
                {
                    resultado = "No";
                    break;
                }
                    
            }
                

           return resultado;
        }
    }

}
