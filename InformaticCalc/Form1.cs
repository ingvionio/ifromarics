namespace InformaticCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form step1 = new Answer();
            step1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form step2 = new FromDec();
            step2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form add = new ADD();
            add.Show();
            this.Hide();
        }
    }
}