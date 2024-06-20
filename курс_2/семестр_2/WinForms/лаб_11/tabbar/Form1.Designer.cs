namespace tabbar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            tabPage3 = new TabPage();
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            tabPage4 = new TabPage();
            groupBox2 = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            button3 = new Button();
            label5 = new Label();
            label6 = new Label();
            tabPage5 = new TabPage();
            button6 = new Button();
            button5 = new Button();
            label8 = new Label();
            label7 = new Label();
            button4 = new Button();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage4.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 388);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Заголовок";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 388);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Вопрос 1";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 351);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(228, 193);
            button1.Name = "button1";
            button1.Size = new Size(330, 34);
            button1.TabIndex = 2;
            button1.Text = "Принять";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(228, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(330, 31);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(212, 79);
            label1.Name = "label1";
            label1.Size = new Size(364, 46);
            label1.TabIndex = 0;
            label1.Text = "Сколько будет 2 + 2 =";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox1);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(label4);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(768, 388);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Вопрос 2";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(35, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(694, 226);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Варианты ответа";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(20, 154);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(47, 29);
            radioButton4.TabIndex = 10;
            radioButton4.TabStop = true;
            radioButton4.Text = "4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(20, 119);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(47, 29);
            radioButton3.TabIndex = 9;
            radioButton3.TabStop = true;
            radioButton3.Text = "3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(20, 84);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(47, 29);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(20, 49);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(47, 29);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(511, 175);
            button2.Name = "button2";
            button2.Size = new Size(177, 34);
            button2.TabIndex = 6;
            button2.Text = "Принять";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 351);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(208, 28);
            label4.Name = "label4";
            label4.Size = new Size(364, 46);
            label4.TabIndex = 4;
            label4.Text = "Сколько будет 2 + 2 =";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(groupBox2);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(label6);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(768, 388);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Вопрос 3";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(button3);
            groupBox2.Location = new Point(34, 86);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(694, 226);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Варианты ответа";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(18, 154);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(48, 29);
            checkBox3.TabIndex = 9;
            checkBox3.Text = "4";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(18, 105);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(141, 29);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "Примерно 3";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(18, 57);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(277, 29);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Натуральное число >3 но <5";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(511, 175);
            button3.Name = "button3";
            button3.Size = new Size(177, 34);
            button3.TabIndex = 6;
            button3.Text = "Принять";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 349);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(207, 26);
            label6.Name = "label6";
            label6.Size = new Size(364, 46);
            label6.TabIndex = 9;
            label6.Text = "Сколько будет 2 + 2 =";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(button6);
            tabPage5.Controls.Add(button5);
            tabPage5.Controls.Add(label8);
            tabPage5.Controls.Add(label7);
            tabPage5.Controls.Add(button4);
            tabPage5.Location = new Point(4, 34);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(768, 388);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Оценка";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(495, 321);
            button6.Name = "button6";
            button6.Size = new Size(252, 34);
            button6.TabIndex = 4;
            button6.Text = "Выход из программы";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(23, 321);
            button5.Name = "button5";
            button5.Size = new Size(252, 34);
            button5.TabIndex = 3;
            button5.Text = "Начать заново";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label8
            // 
            label8.Location = new Point(35, 184);
            label8.Name = "label8";
            label8.Size = new Size(712, 53);
            label8.TabIndex = 2;
            label8.Text = "label8";
            // 
            // label7
            // 
            label7.Location = new Point(35, 93);
            label7.Name = "label7";
            label7.Size = new Size(712, 53);
            label7.TabIndex = 1;
            label7.Text = "label7";
            // 
            // button4
            // 
            button4.Location = new Point(266, 45);
            button4.Name = "button4";
            button4.Size = new Size(252, 34);
            button4.TabIndex = 0;
            button4.Text = "Получить оценку";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox2;
        private Button button3;
        private Label label5;
        private Label label6;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button button6;
        private Button button5;
        private Label label8;
        private Label label7;
        private Button button4;
    }
}
