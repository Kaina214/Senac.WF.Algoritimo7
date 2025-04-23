namespace WF_login
{
    public partial class FormLogin : Form
    {
        public object Aplication { get; private set; }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }






        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.Text = string.Empty;

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            textBox3.Text = "Senha:";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("você clicou no botão 2",
              "Sair",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
                textBox2.Text = "Usuário:";
        }

        private void textBox2_Enter_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "Usuário:")
                textBox2.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }
    }
}