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
    public partial class conversor_longitud : Form
    {
        public conversor_longitud()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            Convertir();
        }

        private void Convertir()
        {
            double convertirMedida = double.Parse(txtObtenerMedida.Text);
            if(cobxUnidadMedida.SelectedItem.ToString() == "Metros" && cobxUnidadMedida2.SelectedItem.ToString() == "Pies")
            {
                double metrosApies = convertirMedida * 3.2808;
                txtConvertir.Text = metrosApies.ToString();
            }
            if(cobxUnidadMedida.SelectedItem.ToString() == "Pies" && cobxUnidadMedida2.SelectedItem.ToString() == "Metros")
            {
                double piesAmetros = convertirMedida / 3.2808;
                txtConvertir.Text = piesAmetros.ToString();
            }
            if(cobxUnidadMedida.SelectedItem.ToString() == "Metros" && cobxUnidadMedida2.SelectedItem.ToString() == "Pulgadas")
            {
                double metrosApulgadas = convertirMedida * 39.37;
                txtConvertir.Text = metrosApulgadas.ToString();
            }
            if(cobxUnidadMedida.SelectedItem.ToString() == "Pulgadas" && cobxUnidadMedida2.SelectedItem.ToString() == "Metros")
            {
                double pulgadasAmetros = convertirMedida / 39.37;
                txtConvertir.Text = pulgadasAmetros.ToString();
            }
            if (cobxUnidadMedida.SelectedItem.ToString() == "Metros" && cobxUnidadMedida2.SelectedItem.ToString() == "Yardas")
            {
                double metrosAyardas = convertirMedida * 1.0936;
                txtConvertir.Text = metrosAyardas.ToString();
            }
            if (cobxUnidadMedida.SelectedItem.ToString() == "Yardas" && cobxUnidadMedida2.SelectedItem.ToString() == "Metros")
            {
                double yardarAmetros = convertirMedida / 1.0936;
                txtConvertir.Text = yardarAmetros.ToString();
            }
            if (cobxUnidadMedida.SelectedItem.ToString() == "Pies" && cobxUnidadMedida2.SelectedItem.ToString() == "Pulgadas")
            {
                double piesApulgadas = convertirMedida * 12;
                txtConvertir.Text = piesApulgadas.ToString();
            }
            if (cobxUnidadMedida.SelectedItem.ToString() == "Pulgadas" && cobxUnidadMedida2.SelectedItem.ToString() == "Pies")
            {
                double pulgadasApies = convertirMedida / 12;
                txtConvertir.Text = pulgadasApies.ToString();
            }
            if (cobxUnidadMedida.SelectedItem.ToString() == "Pies" && cobxUnidadMedida2.SelectedItem.ToString() == "Yardas")
            {
                double piesAyardas = convertirMedida / 3;
                txtConvertir.Text = piesAyardas.ToString();
            }
            if (cobxUnidadMedida.SelectedItem.ToString() == "Yardas" && cobxUnidadMedida2.SelectedItem.ToString() == "Pies")
            {
                double yardasApies = convertirMedida * 3;
                txtConvertir.Text = yardasApies.ToString();
            }
            if (cobxUnidadMedida.SelectedItem.ToString() == "Pulgadas" && cobxUnidadMedida2.SelectedItem.ToString() == "Yardas")
            {
                double pulgadasAyardas = convertirMedida / 36;
                txtConvertir.Text = pulgadasAyardas.ToString();
            }
            if (cobxUnidadMedida.SelectedItem.ToString() == "Yardas" && cobxUnidadMedida2.SelectedItem.ToString() == "Pulgadas")
            {
                double yardasApulgadas = convertirMedida * 36;
                txtConvertir.Text = yardasApulgadas.ToString();
            }
        }
    }
}
