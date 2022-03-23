namespace Calculadora_IMC
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        private void lbpeso_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIMC_Click(object sender, EventArgs e)

        {
            double peso;
            double altura;
            string situacao = "";
            peso = double.Parse(txtps.Text);
            altura = double.Parse(txtal.Text);

            double imc = peso / Math.Pow(altura, 2);

            if (imc < 18.5)
            {
                situacao = "peso abaixo do ideal";
            }
            else if (imc > 18.5 && imc <= 24.9) 
            {
                situacao = "Peso ideal";
            }
            else if (imc > 25.0 && imc <= 29.9) 
            {
                situacao = "Acima do peso ";
            }
            else if (imc > 30.0 && imc <= 34.9) 
            {
                situacao = "Obesidade Grau 1 ";
            }
            else if (imc > 35.0 && imc <= 39.9) 
            {
                situacao = "Obesidade de grau 2";
            }
            else if (imc > 40) 
            {
                situacao = " Obesidade de grau 3 ";
            }

            MessageBox.Show(situacao);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}




