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
    public partial class adivinar_el_numero : Form
    {
        int numeroAleatorio;
        int intentosRestantes;

        public adivinar_el_numero()
        {
            InitializeComponent();
            ReiniciarJuego();
            //Button b = new Button();
            //b.Click += BtnVolveraJugar;
        }

        private void BtnVolveraJugar(object? sender, EventArgs e)
        {
            ReiniciarJuego();
            lblNumerooMensaje.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Click -= BtnVolveraJugar;
                button1.Text = "Adivinar";
                int numeroIngresado = int.Parse(txtNumero.Text);
                if (numeroIngresado == numeroAleatorio)
                {
                    lblNumerooMensaje.Text = "¡Correcto! Has adivinado el número"; lblNumerooMensaje.ForeColor = Color.Green;
                    button1.Text = "Volver a jugar";
                    button1.Click += BtnVolveraJugar;
                }
                else if (numeroIngresado < numeroAleatorio)
                {
                    intentosRestantes--;
                    lblNumerooMensaje.Text = "El numero que ingresaste es menor. Te quedan " + intentosRestantes + " intentos."; lblNumerooMensaje.ForeColor = Color.Red;
                    lblIntentos.Text = intentosRestantes.ToString();
                    if (intentosRestantes == 0)
                    {
                        lblNumerooMensaje.Text = "!lo siento! Te quedaste sin intentos. El numero era " + numeroAleatorio + ".";
                        button1.Text = "Volver a jugar";
                        button1.Click += BtnVolveraJugar;
                    }
                }
                else if (numeroIngresado > numeroAleatorio)
                {
                    intentosRestantes--;
                    lblNumerooMensaje.Text = "El numero que ingresaste es mayor. Te quedan " + intentosRestantes + " intentos."; lblNumerooMensaje.ForeColor = Color.Red;
                    lblIntentos.Text = intentosRestantes.ToString();
                    if (intentosRestantes == 0)
                    {
                        lblNumerooMensaje.Text = "!lo siento! Te quedaste sin intentos. El numero era " + numeroAleatorio + ".";
                        button1.Text = "Volver a jugar";
                        button1.Click += BtnVolveraJugar;
                    }
                }
            }
            catch
            {
                MessageBox.Show("ingrese almenos un valor");
            }
        }

        private void ReiniciarJuego()
        {
            Random random = new Random();
            numeroAleatorio = random.Next(1, 21);//un numero aleatorio del 1 al 100
            intentosRestantes = 4;//tendra 7 intentos
            lblIntentos.Text = intentosRestantes.ToString();
            txtNumero.Text = "";
        }

        private void IndicarNumero(int numero)
        {
            for (int i = 0; i < 100; i++)
            {
                if (numero >= i && numero <= i)
                {

                }
            }
        }
    }
}
