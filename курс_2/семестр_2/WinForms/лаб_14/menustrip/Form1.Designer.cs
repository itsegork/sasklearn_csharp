namespace menustrip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            рисункиToolStripMenuItem = new ToolStripMenuItem();
            котик1ToolStripMenuItem = new ToolStripMenuItem();
            котик2ToolStripMenuItem = new ToolStripMenuItem();
            котик3ToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { рисункиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // рисункиToolStripMenuItem
            // 
            рисункиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { котик1ToolStripMenuItem, котик2ToolStripMenuItem, котик3ToolStripMenuItem });
            рисункиToolStripMenuItem.Name = "рисункиToolStripMenuItem";
            рисункиToolStripMenuItem.Size = new Size(94, 29);
            рисункиToolStripMenuItem.Text = "Рисунки";
            // 
            // котик1ToolStripMenuItem
            // 
            котик1ToolStripMenuItem.Image = (Image)resources.GetObject("котик1ToolStripMenuItem.Image");
            котик1ToolStripMenuItem.Name = "котик1ToolStripMenuItem";
            котик1ToolStripMenuItem.Size = new Size(270, 34);
            котик1ToolStripMenuItem.Text = "Котик №1";
            котик1ToolStripMenuItem.Click += котик1ToolStripMenuItem_Click;
            // 
            // котик2ToolStripMenuItem
            // 
            котик2ToolStripMenuItem.Image = (Image)resources.GetObject("котик2ToolStripMenuItem.Image");
            котик2ToolStripMenuItem.Name = "котик2ToolStripMenuItem";
            котик2ToolStripMenuItem.Size = new Size(270, 34);
            котик2ToolStripMenuItem.Text = "Котик №2";
            котик2ToolStripMenuItem.Click += котик2ToolStripMenuItem_Click;
            // 
            // котик3ToolStripMenuItem
            // 
            котик3ToolStripMenuItem.Image = (Image)resources.GetObject("котик3ToolStripMenuItem.Image");
            котик3ToolStripMenuItem.Name = "котик3ToolStripMenuItem";
            котик3ToolStripMenuItem.Size = new Size(270, 34);
            котик3ToolStripMenuItem.Text = "Котик №3";
            котик3ToolStripMenuItem.Click += котик3ToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 414);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Меню";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem рисункиToolStripMenuItem;
        private ToolStripMenuItem котик1ToolStripMenuItem;
        private ToolStripMenuItem котик2ToolStripMenuItem;
        private ToolStripMenuItem котик3ToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}
