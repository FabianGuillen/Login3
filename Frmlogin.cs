namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "usuario" && txtcontrasena.Text == "clave")
            {
                Frminicio frminicio = new Frminicio();
                this.Hide();
                frminicio.Show();
            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos");
                txtusuario.Clear();
                txtcontrasena.Clear();
            }

        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtusuario.Clear();
            txtcontrasena.Clear();

        }


    }
}

