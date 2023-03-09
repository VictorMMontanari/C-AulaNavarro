namespace TesteForms01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Entrada de Dados
            var lado1 = Convert.ToInt16(textBox1.Text);
            var lado2 = Convert.ToInt16(textBox2.Text);

            //c�lculo (regra do negocio)
            var result = lado1 * lado2;

            //Sa�da de dados
            label1.Text = result.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var aresta = Convert.ToInt16(textBox3.Text);
            int calcular = aresta * aresta * aresta;
            string resultado = Convert.ToString(calcular);
            label4.Text = resultado;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int raio = Convert.ToInt16(textBox4.Text);
            double calcular = pi * raio * raio;
            label5.Text = calcular.ToString();
        }


        private void Button4_Click(object sender, EventArgs e)
        {
            double tempEmCelsius = Convert.ToDouble(textBox5.Text);
            double calculeParaF = 1.8 * tempEmCelsius + 32;
            label8.Text = calculeParaF.ToString();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            double tempEmFarenheit = Convert.ToDouble(textBox6.Text);
            double calculeParaC = (tempEmFarenheit - 32) / 1.8;
            label11.Text = calculeParaC.ToString();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt16(textBox7.Text);
            double b = Convert.ToInt16(textBox8.Text);
            double c = Convert.ToInt16(textBox9.Text);

            double delta = (b * b) - (4 * a * c);
            double raiz1 = ((b * -1) + Math.Sqrt(delta)) / (2 * a);
            double raiz2 = ((b * -1) - Math.Sqrt(delta)) / (2 * a);

            label14.Text = raiz1.ToString();
            label15.Text = raiz2.ToString();
        }
    }
}