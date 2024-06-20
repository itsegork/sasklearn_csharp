using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cstest
{
    public partial class Form1 : Form
    {
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Запретить изменение размера формы
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                count++;
                tabControl1.SelectedTab = tabPage3;
                button2.Visible = false;
            }
            else
            {
                tabControl1.SelectedTab = tabPage3;
                button2.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                count++;
                tabControl1.SelectedTab = tabPage4;
                button3.Visible = false;
            }
            else
            {
                tabControl1.SelectedTab = tabPage4;
                button3.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton12.Checked == true)
            {
                count++;
                tabControl1.SelectedTab = tabPage5;
                button4.Visible = false;
            }
            else
            {
                tabControl1.SelectedTab = tabPage5;
                button4.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                count++;
                tabControl1.SelectedTab = tabPage6;
                button5.Visible = false;
            }
            else
            {
                tabControl1.SelectedTab = tabPage6;
                button5.Visible = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton15.Checked == true)
            {
                count++;
                tabControl1.SelectedTab = tabPage7;
                button6.Visible = false;
            }
            else
            {
                tabControl1.SelectedTab = tabPage7;
                button6.Visible = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton15.Checked == true)
            {
                count++;
                tabControl1.SelectedTab = tabPage8;
                button7.Visible = false;
            }
            else
            {
                tabControl1.SelectedTab = tabPage8;
                button7.Visible = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (radioButton22.Checked == true)
            {
                count++;
                tabControl1.SelectedTab = tabPage9;
                button8.Visible = false;
            }
            else
            {
                tabControl1.SelectedTab = tabPage9;
                button8.Visible = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (radioButton29.Checked == true)
            {
                count++;
                tabControl1.SelectedTab = tabPage10;
                button9.Visible = false;
            }
            else
            {
                tabControl1.SelectedTab = tabPage10;
                button9.Visible = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (radioButton31.Checked == true)
            {
                count++;
                tabControl1.SelectedTab = tabPage11;
                button10.Visible = false;
            }
            else
            {
                tabControl1.SelectedTab = tabPage11;
                button10.Visible = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (radioButton32.Checked == true)
            {
                count++;
                tabControl1.SelectedTab = tabPage12;
                button11.Visible = false;
            }
            else
            {
                tabControl1.SelectedTab = tabPage12;
                button11.Visible = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (radioButton37.Checked == true)
            {
                count++;
                tabControl1.SelectedTab = tabPage13;
                button12.Visible = false;
            }
            else
            {
                tabControl1.SelectedTab = tabPage13;
                button12.Visible = false;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (radioButton39.Checked == true)
            {
                count++;
                tabControl1.SelectedTab = tabPage14;
                button13.Visible = false;
            }
            else
            {
                tabControl1.SelectedTab = tabPage14;
                button13.Visible = false;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (radioButton41.Checked == true)
            {
                count++;
                tabControl1.SelectedTab = tabPage15;
                button14.Visible = false;
            }
            else
            {
                tabControl1.SelectedTab = tabPage15;
                button14.Visible = false;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (radioButton44.Checked == true)
            {
                count++;
                tabControl1.SelectedTab = tabPage16;
                button15.Visible = false;
            }
            else
            {
                tabControl1.SelectedTab = tabPage16;
                button15.Visible = false;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (radioButton48.Checked == true)
            {
                count++;
                tabControl1.SelectedTab = tabPage17;
                button16.Visible = false;
            }
            else
            {
                tabControl1.SelectedTab = tabPage17;
                button16.Visible = false;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (radioButton50.Checked == true)
            {
                count++;
                tabControl1.SelectedTab = tabPage18;
                button17.Visible = false;
            }
            else
            {
                tabControl1.SelectedTab = tabPage18;
                button17.Visible = false;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (radioButton53.Checked == true)
            {
                count++;
                tabControl1.SelectedTab = tabPage19;
                button18.Visible = false;
            }
            else
            {
                tabControl1.SelectedTab = tabPage19;
                button18.Visible = false;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (radioButton58.Checked == true)
            {
                count++;
                tabControl1.SelectedTab = tabPage20;
                button19.Visible = false;
            }
            else
            {
                tabControl1.SelectedTab = tabPage20;
                button19.Visible = false;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (radioButton59.Checked == true)
            {
                count++;
                tabControl1.SelectedTab = tabPage21;
                button20.Visible = false;
            }
            else
            {
                tabControl1.SelectedTab = tabPage21;
                button20.Visible = false;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (radioButton63.Checked == true)
            {
                count++;
                tabControl1.SelectedTab = tabPage22;
                button21.Visible = false;
            }
            else
            {
                tabControl1.SelectedTab = tabPage22;
                button21.Visible = false;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (radioButton66.Checked == true)
            {
                count++;
                tabControl1.SelectedTab = tabPage23;
                button22.Visible = false;
            }
            else
            {
                tabControl1.SelectedTab = tabPage23;
                button22.Visible = false;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (radioButton70.Checked == true)
            {
                count++;
                tabControl1.SelectedTab = tabPage24;
                button23.Visible = false;
            }
            else
            {
                tabControl1.SelectedTab = tabPage24;
                button23.Visible = false;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (radioButton73.Checked == true)
            {
                count++;
                tabControl1.SelectedTab = tabPage25;
                button24.Visible = false;
            }
            else
            {
                tabControl1.SelectedTab = tabPage25;
                button24.Visible = false;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+")
            {
                count++;
                tabControl1.SelectedTab = tabPage26;
                button25.Visible = false;
            }
            else
            {
                tabControl1.SelectedTab = tabPage26;
                button25.Visible = false;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (radioButton76.Checked == true)
            {
                count++;
                tabControl1.SelectedTab = tabPage27;
                button26.Visible = false;
            }
            else
            {
                tabControl1.SelectedTab = tabPage27;
                button26.Visible = false;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (radioButton77.Checked == true)
            {
                count++;
                tabControl1.SelectedTab = tabPage29;
                button28.Visible = false;
            }
            else
            {
                tabControl1.SelectedTab = tabPage29;
                button28.Visible = false;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "delegate void MyDelegate();")
            {
                count++;
                tabControl1.SelectedTab = tabPage28;
                button27.Visible = false;
            }
            else
            {
                tabControl1.SelectedTab = tabPage28;
                button27.Visible = false;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (radioButton81.Checked == true)
            {
                count++;
                tabControl1.SelectedTab = tabPage30;
                button29.Visible = false;
            }
            else
            {
                tabControl1.SelectedTab = tabPage30;
                button29.Visible = false;
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (radioButton85.Checked == true)
            {
                count++;
                tabControl1.SelectedTab = tabPage31;
                button30.Visible = false;
            }
            else
            {
                tabControl1.SelectedTab = tabPage31;
                button30.Visible = false;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (radioButton88.Checked == true)
            {
                count++;
                tabControl1.SelectedTab = tabPage32;
                button31.Visible = false;
            }
            else
            {
                tabControl1.SelectedTab = tabPage32;
                button31.Visible = false;
            }
            label35.Text = $"Ваш результат: {count}/30";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            button17.Visible = true;
            button18.Visible = true;
            button19.Visible = true;
            button20.Visible = true;
            button21.Visible = true;
            button22.Visible = true;
            button23.Visible = true;
            button24.Visible = true;
            button25.Visible = true;
            button26.Visible = true;
            button27.Visible = true;
            button28.Visible = true;
            button29.Visible = true;
            button30.Visible = true;
            button31.Visible = true;
            tabControl1.SelectedTab = tabPage1;
        }
    }
}
