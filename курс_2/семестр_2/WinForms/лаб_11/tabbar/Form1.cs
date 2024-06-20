using System.Windows.Forms;

namespace tabbar
{
    public partial class Form1 : Form
    {
        int b = 0;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "4")
            {
                label2.Text = "Правильно";
                b = b + 1;
            }
            else label2.Text = "Неправильно";
            // прячем кнопку что бы исключить повторный ввод
            // (угадывание ответа)
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                label3.Text = "Правильно";
                b = b + 1;
            }
            else label3.Text = "Неправильно";
            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true &&
                checkBox3.Checked == true &&
                checkBox2.Checked == false)
            {
                label5.Text = "Правильно";
                b = b + 1;
            }
            else label5.Text = "Неправильно";
            button3.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label7.Text = "Набрано баллов= " + Convert.ToString(b); ;
            if (b == 3) label8.Text = "Оценка 5 (отлично)";
            if (b == 2) label8.Text = "Оценка 4(хорошо)";
            if (b == 1) label8.Text = "Оценка 3(удовлетворительно)";
            if (b == 0) label8.Text = "Оценка 2(плохо)";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // переходим на первую вкладку
            tabControl1.SelectedIndex = 0;
            // показываем все кнопки «Проверить» обратно.
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            // скрываем надписи правильно неправильно
            label2.Text = "";
            label3.Text = "";
            label5.Text = "";
            // убираем все галочки кнопочки и надписи в полях ответа
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            textBox1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            // обнуляем баллы и изменяем соответствующие надписи
            b = 0;
            label7.Text = "";
            label8.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}