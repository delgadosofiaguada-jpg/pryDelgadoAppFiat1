namespace pryDelgadoAppFiat11
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                cmdAceptar.Enabled = false;
            }
            else
            {
                cmdAceptar.Enabled = true;
            }
        }
        private void Calcular()
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            string modulo = lstModulo.SelectedItem.ToString();
            int intentosFallidos = 0;

            bool acceso = false;

            if (usuario == "adm" && contraseña == "@1a" && (modulo == "ADM" || modulo == "COM" || modulo == "VTA"))
            {
                acceso = true;
            }
            else if (usuario == "John" && contraseña == "*2b" && modulo == "SIST")
            {
                acceso = true;
            }
            else if (usuario == "Ceci" && contraseña == "@3c" && (modulo == "VTA" || modulo == "ADM"))
            {
                acceso = true;
            }
            else if (usuario == "God" && contraseña == "*@#4d")
            {
                acceso = true;
            }

            if (acceso)
            {
                intentosFallidos = 0;
                this.Hide();
                frmBienvenida frmBienvenida = new frmBienvenida();
                frmBienvenida.ShowDialog();
                this.Show();
            }
            else
            {
                intentosFallidos++;
                MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado");

                if (intentosFallidos >= 2)
                {
                    this.Close();
                }
            }
        }
        private void cmdAceptar_Click(object sender, EventArgs e)
            {
                 Calcular();
            }
      
         
       
    }
}
