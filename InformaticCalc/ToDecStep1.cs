using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Configuration;
using System.Numerics;

namespace InformaticCalc
{

    public partial class Answer : Form
    {
        int stepNum = 0;
        public Answer()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string num = Num.Text;

            if (Num.Text == "" || BaseNum.Text == "")
            {
                MessageBox.Show("вы не ввели число или основание");
                return;
            }
            try
            {
                int.Parse(BaseNum.Text);
                for (int i = 0; i < num.Length; i++)
                {
                    int miss = Program.CharToDigit(num[i]);
                    if (miss == -1)
                    {
                        return;
                    }
                }
            }
            catch
            {
                return;
            }
            int baseNum = int.Parse(BaseNum.Text);

            Num.ReadOnly = true;
            BaseNum.ReadOnly = true;

            if (stepNum == 0)
            {
                int count = 0;
                startWindowText.Text = "Если основание нашей системы больше 10, то для начала нам нужно перевести все буквы в числа, заглавные буквы - это числа от 10 до 36, строчные буквы - это числа от 37 до 62(чем дальше число в алфавите, тем большее число оно обозначает. Теперь давай запишем наше число без букв.)";
                for (int i = 0; i <= num.Length - 1; i++)
                {
                    int digit = Program.CharToDigit(num[i]);
                    if (digit == -1)
                        return;
                    ans.Text += digit.ToString() + " ";
                }
                stepNum++;
            }

            else if (stepNum == 1)
            {
                ans.Text = null;
                startWindowText.Text = "У каждого разряда есть свой номер. Он нам пригодится для перевода числа в десятичную систему. Нумерация начинается с самой правой цифры числа, поэтому для дальнейшего удобства давай перевернём число (запишем его справа навлево)";
                for (int i = num.Length - 1; i >= 0; i--)
                {
                    int digit = Program.CharToDigit(num[i]);

                    if (digit >= baseNum)
                    {
                        MessageBox.Show("Введённое число некорректно. Значение одного из разрядов больше основания системы.");
                        return;
                    }
                    ans.Text += digit.ToString() + " ";
                }
                stepNum++;
            }
            else if (stepNum == 2)
            {
                ans.Text = null;
                int result = 0;
                int power = 0;

                for (int i = num.Length - 1; i >= 0; i--)
                {
                    int digit = Program.CharToDigit(num[i]);

                    if (i == 0)
                        ans.Text += digit.ToString() + " * " + baseNum.ToString() + "^" + power.ToString();
                    else
                        ans.Text += digit.ToString() + " * " + baseNum.ToString() + "^" + power.ToString() + " + ";
                    power++;
                }
                int count = result;
                startWindowText.Text = "Для того чтобы перевести число в десятичную систему необходимо значение каждого разрядя умножить на основание системы в степани этого разряда. Нумерация разрядов начинается с нуля, давай запишем наше выражение (т.к мы перевернули число, то значение крайнего левого разряда мы будем умножать на оснавание в нулевой степени, а значеник каждого последуещего разряда будем умножать на основание в степени на единицу больше.";
                stepNum++;
            }
            else
            {
                startWindowText.Text = "Посчитав выражение, мы получим исходное число в десятичной системе.";
                int result = 0;
                int power = 0;
                for (int i = num.Length - 1; i >= 0; i--)
                {
                    int digit = Program.CharToDigit(num[i]);
                    result += digit * (int)Math.Pow(baseNum, power);
                    power++;
                }
                ans.Text = result.ToString();
                this.Controls.Remove(NextStep);
            }

        }

        private void startWindowText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form start = new Form1();
            start.Show();
            this.Close();
        }
        private void Num_TextChanged(object sender, EventArgs e)
        {

        }

        private void BaseNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {

        }
    }
}
