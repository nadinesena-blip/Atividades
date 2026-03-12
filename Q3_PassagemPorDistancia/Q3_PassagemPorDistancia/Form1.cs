using System.Globalization;

namespace Q3_PassagemPorDistancia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double tarifa, distancia, preco;
           distancia = double.Parse(txtDistancia.Text);

            if (distancia <= 200)
            {
                preco = distancia * 0.50;
            }
            else
            {
                preco = distancia * 0.45;
            }

            // Exibe o resultado formatado
            txtResultado.Text = "Preço da passagem: R$ " + preco.ToString("F2");
        }



    }
}

