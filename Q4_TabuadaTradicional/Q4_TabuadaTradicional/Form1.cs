namespace Q4_TabuadaTradicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Clear();

            int numero = int.Parse(textBox1.Text);

            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add($"{numero} x {i} = {numero * i}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
}
