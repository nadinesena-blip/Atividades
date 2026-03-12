namespace Dolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double Dolar, Cotacao, Real;
            Dolar = Convert.ToDouble(txtDolares.Text);
            Cotacao = Convert.ToDouble(txtCotacao.Text);
            {
                Real = Dolar * Cotacao;

            }
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
