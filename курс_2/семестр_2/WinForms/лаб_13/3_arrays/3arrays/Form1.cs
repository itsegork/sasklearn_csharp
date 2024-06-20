using System.Security.Cryptography.Xml;

namespace _3arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(button1, "Данная кнопка заполняет массив нечетными числами от 1 до 99 и выводит все элементы в textBox");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] array = new int[50];
            int cnt = -1;

            for (int i = 1; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    cnt += 1;
                    array[cnt] = i;
                }
            }

            textBox1.Clear();

            foreach(int num in array)
            {
                textBox1.AppendText(num + "\r\n");
            }

        }
    }
}
