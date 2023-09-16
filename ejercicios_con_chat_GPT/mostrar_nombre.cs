namespace ejercicios_con_google
{
    public partial class mostrar_nombre : Form
    {
        public mostrar_nombre()
        {
            InitializeComponent();
        }

        private void btnMensaje_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"hola {txtNombre.Text}");
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                label1.Text = "ingrese su nombre:"; label1.ForeColor = Color.Red;
                btnMensaje.Enabled = false;
            }
            else
            {
                btnMensaje.Enabled=true;
                label1.Text = "Nombre:";label1.ForeColor= Color.Black;
            }
        }
    }
}