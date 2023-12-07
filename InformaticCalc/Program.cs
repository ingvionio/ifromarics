namespace InformaticCalc
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }
        public static char DigitToChar(int digit)
        {
            if (digit < 10)
            {
                return (char)('0' + digit);
            }
            else if (digit < 36)
            {
                return (char)('A' + digit - 10);
            }
            else if (digit < 51)
            {
                return (char)('a' + digit - 36);
            }
            else
            {
                MessageBox.Show("неверные данные");
                throw new ArgumentException("Invalid digit");
            }
        }

        public static int CharToDigit(char c)
        {
            if (char.IsDigit(c))
            {
                return c - '0';
            }
            else if (char.IsUpper(c))
            {
                return char.ToUpper(c) - 'A' + 10;
            }
            else if (char.IsLower(c))
            {
                return char.ToUpper(c) - 'a' + 36;
            }
            else
            {
                MessageBox.Show("неверные данные");
                throw new ArgumentException("Invalid character");
            }
        }

        static string AddNumbers(string number1, string number2, int baseNumber)
        {
            int carry = 0;
            int maxLength = Math.Max(number1.Length, number2.Length);
            string result = "";

            for (int i = 0; i < maxLength; i++)
            {
                int digit1 = GetDigit(number1, i);
                int digit2 = GetDigit(number2, i);
                int sum = digit1 + digit2 + carry;

                int remainder = sum % baseNumber;
                carry = sum / baseNumber;

                result = remainder.ToString() + result;
            }

            if (carry != 0)
            {
                result = carry.ToString() + result;
            }

            return result;
        }

        public static int GetDigit(string number, int index)
        {
            if (index < number.Length)
            {
                char digitChar = number[number.Length - 1 - index];
                return ConvertToInt(digitChar);
            }

            return 0;
        }

        static int ConvertToInt(char digit)
        {
            if (char.IsDigit(digit))
            {
                return Convert.ToInt32(digit.ToString());
            }
            else if (char.IsUpper(digit))
            {
                return char.ToUpper(digit) - 'A' + 10;
            }
            else
            {
                return char.ToLower(digit) - 'a' + 36;
            }
        }
    }




}
