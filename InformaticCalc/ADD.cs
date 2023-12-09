using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformaticCalc
{
    public partial class ADD : Form
    {
        int stepCount = -1;
        string result = "";
        public ADD()
        {
            InitializeComponent();
        }





        private void startWindowText_TextChanged(object sender, EventArgs e)
        {

        }

        private void NextStep_Click(object sender, EventArgs e)
        {
            if (Num1.Text == "" || BaseNum.Text == "" || Num2.Text == "")
            {
                MessageBox.Show("вы не ввели число или основание");
                return;
            }
            string number1 = Num1.Text;
            string number2 = Num2.Text;

            try
            {
                Convert.ToInt32(BaseNum.Text);

                for (int i = 0; i <number1.Length; i++)
                {
                    int miss = Program.CharToDigit(number1[i]);
                    if (miss == -1)
                    {
                        return;
                    }
                }

                for (int i = 0; i < number2.Length; i++)
                {
                    int miss = Program.CharToDigit(number2[i]);
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

            int baseNumber = Convert.ToInt32(BaseNum.Text);
            Num1.ReadOnly = true;
            Num2.ReadOnly = true;
            BaseNum.ReadOnly = true;


            int maxLength = Math.Max(number1.Length, number2.Length);

            if (stepCount == -1)
            {
                startWindowText.Text = "Для начала запшим два числа в столбик и при необходимости допишем незначашие нули к меньшему числу. После этого мы будем складывать числа поразрядно (т.е. складывать числа, которые расположены друг над другом). Если результат сложения двух цифр числа получится больше основание СС, то мы вычтем из резултата основание, остаток запишем в результат в тот разряд, который мы суммировали (под теми цифрами, которые мы складывали), а в перенос мы запишем единицу. Нажимай на кнопку и программа будет считать каждый разряд";
                int nullCount = Math.Max(number1.Length, number2.Length) - Math.Min(number1.Length, number2.Length);

                if (number1.Length == number2.Length)
                {
                    ans1.Text = number1;
                    ans2.Text = number2;
                }

                else if (number1.Length == maxLength)
                {
                    string nul = "";
                    ans1.Text = number1;
                    for (int i = 0; i < nullCount; i++)
                    {
                        nul += "0";
                    }
                    ans2.Text = nul + number2;
                }

                else
                {
                    string nul = "";
                    ans1.Text = number2;
                    for (int i = 0; i < nullCount; i++)
                    {
                        nul += "0";
                    }

                    ans2.Text = nul + number1;
                }
                stepCount++;
            }

            else if (stepCount != -1 && stepCount < maxLength)
            {
                int carry = Convert.ToInt32(car.Text);
                string textCarry = carry.ToString();
                int nullCount = maxLength - stepCount - 1;
                string nul = "";

                for (int i = 0; i < nullCount; i++)
                {
                    nul += "0";
                }

                int digit1 = Program.GetDigit(number1, stepCount);
                int digit2 = Program.GetDigit(number2, stepCount);
                int sum = digit1 + digit2 + carry;

                startWindowText.Text = "сложим " + (stepCount + 1).ToString() + " разряд. Не забудь, что буквы в выражении - это просто цифры в СС больше 10, первое число - это " + digit1.ToString() + " ,второе число - это " + digit2.ToString();

                int remainder = sum % baseNumber;
                car.Text = (sum / baseNumber).ToString();

                if (sum / baseNumber == 1)
                    startWindowText.Text += " Наша сумма состоит из суммы этих чисел + перенос с предыдущего разряда " + digit1.ToString() + "+" + digit2.ToString() + "+" + textCarry + "=" + sum.ToString() + " Сумма больше или равна основанию СС, поэтому запишем в перенос 1 и вычтем онование из нашей суммы " + sum.ToString() + "-" + baseNumber.ToString() + "=" + (sum - baseNumber).ToString() + " это число мы запишем в результат.";
                if (sum / baseNumber == 0)
                    startWindowText.Text += " Наша сумма состоит из суммы этих чисел + перенос с предыдущего разряда " + digit1.ToString() + "+" + digit2.ToString() + "+" + textCarry + "=" + sum.ToString() + " Cумма меньше основания СС, поэтому просто запишем её в результат ";
                if (remainder >= 10)
                {
                    char rem = Program.DigitToChar(remainder);
                    result = rem.ToString() + result;
                    startWindowText.Text += " Не забудь, что нам надо обозначить это число символом, который соответствует этому числу в нашей СС. В нашем случае - это \"" + rem.ToString() + "\" ,его мы и запишем в резултат";
                }
                else
                {
                    result = remainder.ToString() + result;
                }
                answer.Text = nul + result;

                stepCount++;
                if (Convert.ToInt32(car.Text) == 0 && stepCount == maxLength)
                {
                    startWindowText.Text = "Сложение закончено, теперь можешь вернуться на главный экран";
                    this.Controls.Remove(NextStep);
                }
            }

            else if (Convert.ToInt32(car.Text) != 0)
            {
                car.Text = "0";
                label3.Text = "1";
                startWindowText.Text = "Сложение закончено, но у нас осталась единичка в переносе, её нужно записать в новый разряд. На этом всё. Теперь можешь вернуться на главный экран";
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ReturnBegin_Click(object sender, EventArgs e)
        {
            Form start = new Form1();
            start.Show();
            this.Close();
        }
    }
}
