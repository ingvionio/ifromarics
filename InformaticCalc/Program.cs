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
        static string ConvertFromDecimal(int decimalNumber, int baseNumber)
        {
            string result = "";

            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % baseNumber;
                decimalNumber /= baseNumber;

                result = DigitToChar(remainder) + result;
            }

            return result;
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

        
    }
}