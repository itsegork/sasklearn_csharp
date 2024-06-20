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
                label2.Text = "���������";
                b = b + 1;
            }
            else label2.Text = "�����������";
            // ������ ������ ��� �� ��������� ��������� ����
            // (���������� ������)
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                label3.Text = "���������";
                b = b + 1;
            }
            else label3.Text = "�����������";
            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true &&
                checkBox3.Checked == true &&
                checkBox2.Checked == false)
            {
                label5.Text = "���������";
                b = b + 1;
            }
            else label5.Text = "�����������";
            button3.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label7.Text = "������� ������= " + Convert.ToString(b); ;
            if (b == 3) label8.Text = "������ 5 (�������)";
            if (b == 2) label8.Text = "������ 4(������)";
            if (b == 1) label8.Text = "������ 3(�����������������)";
            if (b == 0) label8.Text = "������ 2(�����)";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // ��������� �� ������ �������
            tabControl1.SelectedIndex = 0;
            // ���������� ��� ������ ����������� �������.
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            // �������� ������� ��������� �����������
            label2.Text = "";
            label3.Text = "";
            label5.Text = "";
            // ������� ��� ������� �������� � ������� � ����� ������
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            textBox1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            // �������� ����� � �������� ��������������� �������
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