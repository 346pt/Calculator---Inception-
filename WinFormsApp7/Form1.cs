namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = a + b;
            MessageBox.Show("Результат сложения " + c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = a - b;
            MessageBox.Show("Результат вычитания " + c);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = a / b;
            MessageBox.Show("Результат деления " + c);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = a * b;
            MessageBox.Show("Результат умножения " + c);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            MessageBox.Show("Возведение в степень " + Math.Pow(a, b));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            MessageBox.Show("Получение корня " + Math.Sqrt(a));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            MessageBox.Show("Косинус " + Math.Cos(a));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            MessageBox.Show("Косинус " + Math.Sin(a));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            MessageBox.Show("Тагенс " + Math.SinCos(a));
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            textBox3.Text = Convert.ToString(a, 2);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            textBox3.Text = Convert.ToString(a, 8);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            textBox3.Text = Convert.ToString(a, 16);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            textBox3.Text = Convert.ToString(a, 2);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            textBox3.Text = Convert.ToString(a, 8);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            textBox3.Text = Convert.ToString(a, 16);
        }
    }
}