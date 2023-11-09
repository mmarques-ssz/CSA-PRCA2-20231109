namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Lampada lampadinha;
        public Form1()
        {
            InitializeComponent();
            lampadinha = new Lampada();
            atualizaLampada();
        }

        public void atualizaLampada()
        {
            picLampada.Image = (lampadinha.getEstado()) ?
                WinFormsApp1.Properties.Resources.acesa :
                WinFormsApp1.Properties.Resources.apagada;
            btnAciona.Text = (lampadinha.getEstado()) ? "OFF" : "ON";
        }

        private void btnAcender_Click(object sender, EventArgs e)
        {
            lampadinha.acender();
            atualizaLampada();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            lampadinha.apagar();
            atualizaLampada();
        }

        private void btnAciona_Click(object sender, EventArgs e)
        {
            if (lampadinha.getEstado())
                lampadinha.apagar();
            else
                lampadinha.acender();
            atualizaLampada();

        }
    }
}