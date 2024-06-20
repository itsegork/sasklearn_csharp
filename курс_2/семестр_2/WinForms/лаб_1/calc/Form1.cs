using System;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = 0;
            if (comboBox1.Text == "+")
            {
                c = a + b;
            }
            else if (comboBox1.Text == "-")
            {
                c = a - b;
            }
            else if (comboBox1.Text == "*")
            {
                c = a * b;
            }
            else
            {
                c = a / b;
            }
            textBox3.Text = $"{c}";
        }
    }
}
