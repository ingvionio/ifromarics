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
    public partial class FromDec : Form
    {
        int stepNum = 0;
        public FromDec()
        {
            InitializeComponent();
        }

        private void NextStep_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(Num.Text);
                Convert.ToInt32(BaseNum.Text);
            }

            catch
            {
                MessageBox.Show("Вы ввели неправильные данные");
                return;
            }

            int decimalNumber = Convert.ToInt32(Num.Text);
            int baseNumber = Convert.ToInt32(BaseNum.Text);

            if (stepNum == 0)
            {
                while (decimalNumber > 0)
                {
                    int remainder = decimalNumber % baseNumber;
                    int del = decimalNumber / baseNumber;
                    ans.Text += decimalNumber.ToString() + "/" + baseNumber.ToString() + "=" + del.ToString() + " и остаток " + remainder.ToString() + ", ";
                    decimalNumber /= baseNumber;
                }

                startWindowText.Text = "Целая часть переводится из десятичной системы счисления в другую систему счисления с помощью последовательного деления целой части числа на основание системы счисления до получения целого остатка, меньшего основания системы счисления. Результатом перевода будет являться запись из остатков, начиная с последнего. Давай запишем с тобой остактки от деления твоего числа. Нам осталось только записать остатки в обратном поряядке. Давай это и сделаем";
                stepNum++;
            }

            else if (stepNum == 1)
            {
                if (baseNumber > 10)
                {
                    startWindowText.Text = "Осталось одно маленькое преобразование. Если остаток получился больше 10 (такое может произойти если основание системы, в которую мы переводим больше 10), то нужно этот остаток заменить на символ соответсвующий этому числу. Для числел  с 11 до 36 это заглавные буквы английского алфавита, а для чисел с 37 до 50 это строчные буквы английского алфавита.)";
                }
                else
                {
                    startWindowText.Text = "Это и есть наш ответ";
                    this.Controls.Remove(NextStep);
                }
                string result = "";
                while (decimalNumber > 0)
                {
                    int remainder = decimalNumber % baseNumber;
                    decimalNumber /= baseNumber;

                    result = remainder.ToString() + " " + result;
                    ans.Text = result;
                }
                stepNum++;
            }

            else if (baseNumber > 10)
            {
                startWindowText.Text = "Это и есть наш ответ";
                string result = "";
                while (decimalNumber > 0)
                {
                    int remainder = decimalNumber % baseNumber;
                    decimalNumber /= baseNumber;

                    result = Program.DigitToChar(remainder) + result + " ";
                    ans.Text = result;
                }
                this.Controls.Remove(NextStep);
            }
        }

        private void ReturnBegin_Click(object sender, EventArgs e)
        {
            Form start = new Form1();
            start.Show();
            this.Close();
        }
    }
}
