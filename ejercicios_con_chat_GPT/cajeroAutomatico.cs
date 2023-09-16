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
    public partial class cajeroAutomatico : Form
    {
        public cajeroAutomatico()
        {
            InitializeComponent();
        }

        private void btnTransaccion_Click(object sender, EventArgs e)
        {
            try
            {
                int SaInicial = int.Parse(txtSaldoInicial.Text);
                int MoRetirar = int.Parse(txtMontoAretirar.Text);

                if (MoRetirar < 500)
                {
                    MessageBox.Show("El minimo a retirar es 500");
                }
                else
                {
                    int Transaccion = SaInicial - MoRetirar;
                    MessageBox.Show("La transaccion se ha hecho con exito");
                    lblSaldoActual.Text = Transaccion.ToString();
                    txtSaldoInicial.Text = "";
                    txtMontoAretirar.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Ingrese solo numeros");
            }
            
            
        }
    }
}
