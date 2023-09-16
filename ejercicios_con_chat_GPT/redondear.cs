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
    public partial class redondear : Form
    {
        public redondear()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero = double.Parse(txtRedondear.Text);
            int multiplo = 10;
            int resultado = (int)Math.Round(numero / multiplo) * multiplo;
            txtRedondear.Text = resultado.ToString();
        }
    }
}
