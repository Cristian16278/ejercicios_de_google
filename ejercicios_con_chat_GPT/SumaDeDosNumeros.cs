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
    public partial class SumaDeDosNumeros : Form
    {
        public SumaDeDosNumeros()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int primer_numero = Convert.ToInt32(txtPrimerNumero.Text);
            int segundo_numero = Convert.ToInt32(txtSegundoNumero.Text);

            MessageBox.Show($"La suma de {primer_numero} y {segundo_numero} es igual a {primer_numero + segundo_numero}");
        }
    }
}
