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
    public partial class Calculadora_simple : Form
    {
        
        public Calculadora_simple()
        {
            InitializeComponent();
        }

        private void Sumar()
        {
            //listo
            var (PrimerNumero, SegundoNumero) = Obtenerdatos();
            double resultado = PrimerNumero + SegundoNumero;
            lblResultado.Text = resultado.ToString();
        }

        private void Restar()
        {
            //listo
            var (PrimerNumero, SegundoNumero) = Obtenerdatos();
            double resultado = PrimerNumero - SegundoNumero;
            lblResultado.Text = resultado.ToString();
        }

        private void Multiplicar()
        {
            //listo
            var (PrimerNumero, SegundoNumero) = Obtenerdatos();
            double resultado = PrimerNumero * SegundoNumero;
            lblResultado.Text = resultado.ToString();
        }

        private void Dividir()
        {
            //listo
            var (PrimerNumero, SegundoNumero) = Obtenerdatos();
            double resultado = PrimerNumero / SegundoNumero;
            lblResultado.Text = resultado.ToString();
        }

        private (double,double) Obtenerdatos()
        {
            try 
            {
                double PrNumero = Convert.ToDouble(txtPrimerNumero.Text);
                double SegNumero = Convert.ToDouble(txtSegundoNumero.Text);

                return (PrNumero, SegNumero);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ingrese solo numeros con o sin punto decimal" + ex);
                return (0, 0);//<----para no tener el problema: "no todas las rutas de acceso de codigo devuelven un valor. "
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if(rdbtnSumar.Checked)
            {
                Sumar();
            }
            if(rdbtnRestar.Checked)
            {
                Restar();
            }
            if (rdbtnMultiplicar.Checked)
            {
                Multiplicar();
            }
            if(rdbtnDividir.Checked)
            {
                Dividir();
            }
        }

        private void rdbtnDividir_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnDividir.Checked)
            {
                label2.Text = "Entre:";
            }
            else
            {
                label2.Text = "Seg.Numero";
            }
        }
    }
}
