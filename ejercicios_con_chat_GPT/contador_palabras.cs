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
    public partial class contador_palabras : Form
    {
        public contador_palabras()
        {
            InitializeComponent();
        }

        private void btnContarPalabras_Click(object sender, EventArgs e)
        {
            string leer = txtLeerPalabras.Text.Trim();
            int catidadpalabras = Contarpalabras(leer);
            label1.Text = "Este texto tiene " + catidadpalabras.ToString() + " palabras";
        }

        private int Contarpalabras(string texto)
        {
            string[] palabras = texto.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return palabras.Length;
        }
    }
}
