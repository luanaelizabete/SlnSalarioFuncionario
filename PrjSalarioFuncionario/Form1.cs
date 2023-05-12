using System.Drawing.Text;

namespace PrjSalarioFuncionario
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            double salarioL, salarioB, descontoVt = 0, descontoCnv = 0, descontoImp;
            salarioB = double.Parse(textBox1.Text);

            if (!double.TryParse(textBox2.Text, out salarioL))
            {
                MessageBox.Show("Valor do salário inválido");
            }

            if (checkBox1.Checked)
            {
                descontoVt = salarioB * 0.06;
            }
            else
            {

                if (checkBox2.Checked)
                {
                    descontoCnv = 20.00;
                }
                else
                {

                    if (salarioB < 980.00)
                    {
                        descontoImp = salarioB * 0.08;
                    }

                    else if (salarioB < 1450.00)
                    {
                        descontoImp = salarioB * 0.09;
                    }

                    else if (salarioB < 2120.00)
                    {
                        descontoImp = salarioB * 0.01;
                    }

                    else
                    {
                        descontoImp = salarioB * 0.11;
                    }

                    salarioL = salarioB - descontoImp - descontoVt - descontoCnv;

                    textBox2.Text = salarioL.ToString();

                    textBox2.Text = ("Seu salário líquido é: " + salarioL);

                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
       
        }
    }
}