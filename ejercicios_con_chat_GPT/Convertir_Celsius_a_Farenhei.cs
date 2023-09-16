using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios_con_google
{
    public partial class Convertir_Celsius_a_Farenhei : Form
    {
        public Convertir_Celsius_a_Farenhei()
        {
            InitializeComponent();
        }

        private void CelsiusAfahrenheit(string celsius)
        {
            try
            {
                double Cels = Convert.ToDouble(celsius);
                double resultado = (Cels * 1.8) + 32;
                lblResultadoGrados.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("ingrese valores o no ingrese letras","Advertencia!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void FahrenheitAcelsius(string fahrenheit)
        {
            try
            {
                double fahre = Convert.ToDouble(fahrenheit);
                double resultado = (fahre - 32) / 1.8;
                lblResultadoGrados.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("ingrese valores o no ingrese letras", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdbtnCelaFah_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnCelaFah.Checked)
            {
                lblGrados1.Text = "Grados Celsius";
                lblGrados2.Text = "Grados Fahrenheit";
                if(!string.IsNullOrEmpty(txtGrados.Text))
                {
                    txtGrados.Text = lblResultadoGrados.Text;
                    CelsiusAfahrenheit(txtGrados.Text);
                }
                else
                {
                    
                }
            }
            else
            {
                lblGrados1.Text = "Grados Fahrenheit";
                lblGrados2.Text = "Grados Celsius";
                if (!string.IsNullOrEmpty(txtGrados.Text))
                {
                    txtGrados.Text = lblResultadoGrados.Text;
                    FahrenheitAcelsius(txtGrados.Text);
                }
                else
                {

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbtnCelaFah.Checked)
            {
                CelsiusAfahrenheit(txtGrados.Text);
            }
            if (rdbtnFahaCel.Checked)
            {
                FahrenheitAcelsius(txtGrados.Text);
            }
        }

        private void txtGrados_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGrados.Text))
            {
                btnCalcular.Enabled = false;
            }
            else
            {
                btnCalcular.Enabled = true;
            }
        }
    }
}
