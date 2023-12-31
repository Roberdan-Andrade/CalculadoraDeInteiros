namespace CalculadoraDeInteiros
{
    public partial class Form1 : Form
    {
        public int resultado = 0;
        public int num_temp = 0;
        public string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void DigitaNumero(int num)
        {
            num_temp = (num_temp * 10) + num;

            display.Text = num_temp.ToString();
        }

        private void DigitaOperacao(string operador)
        {
            if(operacao != "")
            {
                CalculaResultado();
            }
            else
            {
                resultado = num_temp;
            }

            num_temp = 0;

            operacao = operador;
        }

        private void CalculaResultado()
        {
            switch (operacao)
            {
                case "+":
                    resultado = resultado + num_temp; break;

                case "-":
                    resultado = resultado - num_temp; break;

                case "*":
                    resultado = resultado * num_temp; break;

                case "/":
                    resultado = resultado / num_temp; break;
            }

            display.Text = Convert.ToString(resultado);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DigitaNumero(3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DigitaNumero(1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DigitaNumero(8);
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            DigitaNumero(0);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            DigitaNumero(2);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            DigitaNumero(4);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            DigitaNumero(5);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            DigitaNumero(6);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            DigitaNumero(7);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            DigitaNumero(9);
        }

        private void numero_temp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            DigitaOperacao("+");
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            DigitaOperacao("-");
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            DigitaOperacao("*");
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            DigitaOperacao("/");
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            CalculaResultado();

            resultado = 0;
            num_temp = 0;
            operacao = "";
        }
    }
}
