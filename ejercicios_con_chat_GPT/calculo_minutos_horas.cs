using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios_de_google
{
    public partial class calculo_minutos_horas : Form
    {
        const int MINUTOSENHORAS = 60;
        const int HORASENDIAS = 24;
        public calculo_minutos_horas()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double duracion = double.Parse(txtDuracion.Text);
                double cantidad = double.Parse(txtCantidad.Text);
                double resultado = CalcularMinutosHoras(duracion, cantidad);
                double numeroRedondeado = Math.Round(resultado, 2);
                if (numeroRedondeado > 24)
                {
                    double dias = CalcularHorasDias(numeroRedondeado);
                    double diasRedondeado = Math.Round(dias,1);
                    MessageBox.Show($"Hay {numeroRedondeado} horas en {cantidad} videos, que tambien es equivalente a {diasRedondeado} dias");
                }
                else
                {
                    MessageBox.Show($"Hay {numeroRedondeado} horas en {cantidad} videos");
                }
                
            }
            catch(FormatException)
            {
                MessageBox.Show("Ingrese valores","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private double CalcularMinutosHoras(double duracion, double cantidad)
        {
            double horascalculado = duracion / MINUTOSENHORAS;
            double resultado = horascalculado * cantidad;
            return resultado;
        }

        private double CalcularHorasDias(double horas)
        {
            double calculo = horas / HORASENDIAS;
            return calculo;
        }
    }
}
