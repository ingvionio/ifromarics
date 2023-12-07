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
        public ADD()
        {
            InitializeComponent();
        }




        private void startWindowText_TextChanged(object sender, EventArgs e)
        {

        }

        private void NextStep_Click(object sender, EventArgs e)
        {
            string number1 = Num1.Text;
            string number2 = Num2.Text;
            int baseNumber = Convert.ToInt32(BaseNum.Text);

            int carry = 0;
            int maxLength = Math.Max(number1.Length, number2.Length);
            string result = "";

            for (int i = 0; i < maxLength; i++)
            {
                int digit1 = Program.GetDigit(number1, i);
                int digit2 = Program.GetDigit(number2, i);
                int sum = digit1 + digit2 + carry;

                int remainder = sum % baseNumber;
                carry = sum / baseNumber;

                result = remainder.ToString() + result;
            }

            if (carry != 0)
            {
                result = carry.ToString() + result;
            }

            //return result;
        }
    }
}
