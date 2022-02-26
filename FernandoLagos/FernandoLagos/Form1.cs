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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        private void CalcularButton1_Click(object sender, EventArgs e)
        {
            DateTime RealizacionDeposito = FechaDepositoDateTimePicker.Value;
            int MesDelDeposito = RealizacionDeposito.Month;
            decimal Capital = Convert.ToDecimal(CapitalTextBox.Text);            
            decimal TasaInteres = 0.025M;
            decimal[] Interes = new decimal[12];
           
            int cont = 0;

            for (int i = (MesDelDeposito-1); i < Interes.Length; i++)
            {
                cont = cont + 1;
                Interes[i] = Capital * TasaInteres * cont;
            }

            string[] Meses = { "Enero", "Ferbrero", "Marzo", "Abril", "Mayo",
                                "Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre" };

            for (int i = 0; i < Meses.Length; i++)
            {
                MostrarDatosListBox.Items.Add((i+1) + "." + "  " + Meses[i] +"  Lps."+Interes[i]);
            }
                   
        }

        
    }
}
