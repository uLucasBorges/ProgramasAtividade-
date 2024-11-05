using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public List<int> Numeros = new List<int>();
        public List<char> Operacao = new List<char>();
        public Form1()
        {
            InitializeComponent();
        }

         

        private void button11_Click(object sender, EventArgs e)
        {
            visor.Text += "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            visor.Text += "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            visor.Text += "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            visor.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            visor.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            visor.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            visor.Text += "6";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            visor.Text += "7";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            visor.Text += "8";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            visor.Text += "9";

        }

        private void buttonDividir_Click_1(object sender, EventArgs e)
        {

            Numeros.Add(int.Parse(visor.Text));
            Operacao.Add('/');
            visor.Text = "";

        }

        private void buttonSomar_Click_1(object sender, EventArgs e)
        {
            Numeros.Add(int.Parse(visor.Text));
            Operacao.Add('+');
            visor.Text = "";

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            visor.Text = "";
            Numeros.Clear();
            Operacao.Clear();
        }

        private void buttonSubtrair_Click(object sender, EventArgs e)
        {
            Numeros.Add(int.Parse(visor.Text));
            Operacao.Add('-');
            visor.Text = "";
        }

        private void buttonMultiplicar_Click_1(object sender, EventArgs e)
        {
            Numeros.Add(int.Parse(visor.Text));
            Operacao.Add('x');
            visor.Text = "";

        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            // Adiciona o �ltimo n�mero ao pressionar o bot�o de igual
            Numeros.Add(int.Parse(visor.Text));

            int resultado = Numeros[0]; // Come�a com o primeiro n�mero

            // Itera pelas opera��es
            for (int i = 0; i < Operacao.Count; i++)
            {
                var numero2 = Numeros[i + 1]; // Pega o pr�ximo n�mero
                var operador = Operacao[i];

                resultado = operador switch
                {
                    'x' => resultado * numero2,
                    '-' => resultado - numero2,
                    '+' => resultado + numero2,
                    '/' => resultado / numero2,
                    _ => Numeros[0]
                };
            }

            // Mostra o resultado final
            visor.Text = resultado.ToString();

            // Limpa as listas ap�s o c�lculo
            Numeros.Clear();
            Operacao.Clear();
        }
    }
}