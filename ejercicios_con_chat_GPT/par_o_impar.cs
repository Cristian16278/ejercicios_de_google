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
    public partial class par_o_impar : Form
    {
        public par_o_impar()
        {
            InitializeComponent();
        }

        private void btnParOrImpar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);

            if (numero%2 == 0)
            {
                MessageBox.Show($"el numero {numero} es par");
            }
            else
            {
                MessageBox.Show($"el numero {numero} es impar");
            }
        }
    }
}
