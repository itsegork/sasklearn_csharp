using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://" + comboBox1.Text);

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                // Проверяем нажата ли клавиша Enter (код 13). Аргумент е - код нажатой клавиши
                if (e.KeyChar.Equals((char)13))
                {
                    // Если Enter нажат, то вызываем событие нажатия на кнопку "Перейти"
                    button4_Click(sender, e);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            button5.Visible = false;
            textBox2.Text = comboBox1.Text;
            // Очищаем список от содержимого
            listBox1.Items.Clear();
            // Создаём переменную reader для чтения из файла browser.ini
            using (StreamReader reader = new StreamReader("C:\\browser.ini"))
            {
                // Считываем первую строку чтобы получить число строк в списке
                string z = reader.ReadLine();
                //В цикле считываем остальные строки из файла
                for (int j = 0; j < Convert.ToDouble(z); j++)
                    listBox1.Items.Add(reader.ReadLine());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            button5.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Добавляем в список адрес и комментарий
            //Символ вертикальная черта будет в последующем использоваться
            //как разделитель комментария и адреса сайта
            listBox1.Items.Add(textBox1.Text + "|" + textBox2.Text);
            // Создаём переменную sw для записи данных в поток (файл)
            using (StreamWriter sw = new StreamWriter("C:\\browser.ini"))
            {
                // Первой строкой записываем в файл число строк в нашем списке
                sw.WriteLine(listBox1.Items.Count.ToString());
                // В цикле записываем все строки в файл.
                // Count - число строк в списке
                for (int j = 0; j < listBox1.Items.Count; j++)
                    sw.WriteLine(listBox1.Items[j]);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Проверяем, есть ли в списке выделенная строка
            if (listBox1.SelectedIndex == -1)
            // Если нет, то выводим сообщение.
            MessageBox.Show("Нет выделенной строки");
            else
            // Иначе .. Удаляем выделенную строку
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            //Сохраняем новый список в файле
            using (StreamWriter sw = new StreamWriter("C:\\browser.ini"))
            {
            sw.WriteLine(listBox1.Items.Count.ToString());
            for (int j = 0; j < listBox1.Items.Count; j++)
            sw.WriteLine(listBox1.Items[j]);
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string str = listBox1.SelectedItem.ToString();
            string newstr = "";
            int flag = 0; //flag определяет разделитель |
            char c;
            int k = str.Length;
            //Выделяем из строки адрес сайта
            for (int j = 0; j < k; j++)
            {
                c = str[j];
                if (flag != 0) newstr += c;
                if (c == '|') flag = 1;
            }
            //Подставляем в адресную строку адрес сайта
            comboBox1.Text = newstr;
            webBrowser1.Navigate("http://" + comboBox1.Text);
        }
    }
}

