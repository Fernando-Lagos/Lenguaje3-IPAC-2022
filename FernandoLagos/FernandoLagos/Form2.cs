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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private async void CalcularButton_Click(object sender, EventArgs e)
        {
            string Producto = ProductoTextBox.Text;
            decimal PrecioUnitario = Convert.ToDecimal(PrecioTextBox2.Text);

            await CalculoDescuentoAsync(PrecioUnitario);
        }
        private async Task<decimal> CalculoDescuentoAsync(decimal Subtotal)
        {
            var Descuento = await Task.Run(() =>
            {
                return (Subtotal * 0.15M);
            });
            DescuentoTextBox.Text = Descuento.ToString();

            var TotalAPagar = await Task.Run(() =>
            {
                return (Subtotal - Descuento);
            });
            TotalAPagarTextBox.Text = TotalAPagar.ToString();

            return TotalAPagar;
        }

    }
}
