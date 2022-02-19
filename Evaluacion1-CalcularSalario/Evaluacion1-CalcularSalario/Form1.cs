using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion1_CalcularSalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime FechaNacimiento = FechaNacimientoDateTimePicker.Value;
            DateTime FechaContratacion = FechaInicioDateTimePicker1.Value;
            int _PromedioVentas = Convert.ToInt32(PromedioVentasTextBox.Text);
            double SueldoBase = Convert.ToDouble(SalarioTextBox.Text);

            int Edad = CalcularEdad(FechaNacimiento);
            int AntiguedadEmpleado = CalcularAntiguedadEmpleado(FechaContratacion);
            int PromedioVentas = PromedioDeVentas(_PromedioVentas);
            double SalarioActual = 0;

            if (_PromedioVentas > 10000 && Edad >= 30 && AntiguedadEmpleado >= 10)
            {
                SalarioActual = CalculoSalarioActual(SueldoBase);
                SalarioNuevoTextBox.Text = Convert.ToString(SalarioActual);
            }
           
        }

        //Inicio funcion calculo de edad empleado
        private int CalcularEdad (DateTime _FechaNacimiento)
        {
            DateTime FechaNacimiento = _FechaNacimiento;
            DateTime FechaActual = DateTime.Now;

            int Edad = 0;

            if (FechaNacimiento > FechaActual)
            {
                MessageBox.Show("La fecha de nacimiento ingresada es mayor a la fecha actual", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            {
                Edad = (FechaActual.Year - FechaNacimiento.Year);
                if(FechaNacimiento.Month > FechaActual.Month)
                {
                    --Edad;
                }
                if (Edad < 30 )
                {
                    MessageBox.Show("No cumple con los requisitos de edad para el aumento", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return Edad;
        } // Fin Funcion Calcular edad empleado

        //Inicio funcion calcular antiguedad empleado
        private int CalcularAntiguedadEmpleado(DateTime _FechaContratacion)
        {
            DateTime FechaContratacion = _FechaContratacion;
            DateTime FechaActual = DateTime.Now;

            int AntiguedadEmpleado=0;

            if(FechaContratacion > FechaActual)
            {
                MessageBox.Show("La fecha de contratacion ingresada es mayor a la fecha actual","Validacion",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return 0;
            }
            {
                AntiguedadEmpleado = (FechaActual.Year - FechaContratacion.Year);

                if (FechaContratacion.Month > FechaActual.Month)
                {
                    --AntiguedadEmpleado;
                }
                if (AntiguedadEmpleado < 10)
                {
                    MessageBox.Show("No cumple con los requisitos de antiguedad para el aumento", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return AntiguedadEmpleado;
        }// Fin Funcion Calcular antiguedad empleado

        //Inicio Funcion Validacion ventas
        private int PromedioDeVentas(int _VentasPromedio)
        {
            int VentasPromedio = _VentasPromedio;

            if (VentasPromedio <= 10000)
            {
                MessageBox.Show("Su promedio de ventas no cumple con el requisito","Validacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return 0;
            }
            return VentasPromedio;
        } //Fin funcion promedio Ventas

        //Inicio Funcion Calculo de Salario
        private double CalculoSalarioActual (double _Salario_Base)
        {
            double SalarioBase = _Salario_Base;
            double Aumento = 0.05;
            double SalarioActual = SalarioBase + (SalarioBase * Aumento);

            return SalarioActual;
        } //fin funcion calculo SalarioActual
    }
}
