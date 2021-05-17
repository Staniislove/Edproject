using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPRT
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics gr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //button1 = new Button();
            //button1.Text = "Start";
            //button1.Location = new Point(0, 0);
            //button1.Size = new Size(150, 150);
            //button1.Click += button1_Click;

            //button2 = new Button();
            //button2.Text = "Stop";
            //button2.Location = new Point(300, 0);
            //button2.Size = new Size(150, 150);
            //button2.Click += button2_Click;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bmp = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            gr = Graphics.FromImage(bmp);
            gr.CopyFromScreen(0, 0, 0, 0, new Size(bmp.Width, bmp.Height));
            pictureBox1.Image = bmp;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
