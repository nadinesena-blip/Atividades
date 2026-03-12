namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Gerar_Click(object sender, EventArgs e)
        {

            for (int i = 1; i <= 10; i++)
            {
                int n; Console.ReadLine();
                int resultado = n * i;
               txtNumero.Add($"{n} x {i} = {resultado}");
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
}
