namespace _5arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] array = new int[100];
            int[] array2 = new int[100];
            int[] array3 = new int[100];
            int average = 0;
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(10, 30);
            }

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rand.Next(10, 30);
            }
            
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = array[i] + array2[i];
                average += array3[i];
            }

            foreach (int num in array)
            {
                textBox1.AppendText(num + "\r\n");
            }

            foreach (int num in array2)
            {
                textBox2.AppendText(num + "\r\n");
            }

            foreach (int num in array3)
            {
                textBox3.AppendText(num + "\r\n");
            }

            average = average / array3.Length;
            int min = array3.Min();
            int max = array3.Max();

            textBox4.Text = ($"Минимальное число: {min} \r\n" +
                             $"Максимальное число: {max} \r\n" +
                             $"Среднее арифметическое: {average}");

        }
    }
}
