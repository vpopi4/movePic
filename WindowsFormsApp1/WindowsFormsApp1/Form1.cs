using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int a=0;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Height = 440;
            this.Width = 320;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            a = 1;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            a = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            a = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
            a = 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Start();
            a = 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Start();
            a = 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Start();
            a = 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer1.Start();
            a = 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            a = 10;
            timer3.Start();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            a = 11;
            timer3.Start();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            a = 12;
            timer3.Stop();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int value = random.Next(0, 8);

            a = value;
        }

        //__________________________________________________________________________________________________________________________________________

        private void scale1()
        {
            pictureBox1.Size = new Size (pictureBox1.Size.Width + 10, pictureBox1.Size.Height + 10);
            timer2.Start();
        }

        private void scale2()
        {
            pictureBox1.Size = new Size(pictureBox1.Size.Width - 10, pictureBox1.Size.Height - 10);
            timer2.Stop();
        }

        //____________________________________________________________________________________________________________________________________________

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();

            int value = random.Next(0, 3);

            if (pictureBox1.Location.X <= 0)
            {
                int[] array = { 4, 7, 8 };

                //scale1();

                a = array[value];

                //switch (a)
                //{
                //    case 2:
                //        a = 4;
                //        break;
                //    case 6:
                //        a = 8;
                //        break;
                //    case 9:
                //        a = 7;
                //        break;
                //}

            }

            if (pictureBox1.Location.Y <= 0)
            {
                int[] array = { 3, 8, 9 };

                a = array[value];

                //scale1();

                //if (a == 6)
                //{
                //    a = 8;
                //}

                //if (a == 1)
                //{
                //    a = 3;
                //}

                //if (a == 7)
                //{
                //    a = 9;
                //}
            }

            if (pictureBox1.Location.X >= 420)
            {
                int[] array = { 2, 6, 9 };

                a = array[value];

                //scale1();
                //if (a == 7)
                //{
                //    a = 9;
                //}

                //if (a == 4)
                //{
                //    a = 2;
                //}

                //if (a == 8)
                //{
                //    a = 6;
                //}
            }

            if (pictureBox1.Location.Y >= 320)
            {
                int[] array = { 1, 6, 7 };

                a = array[value];

                //scale1();
                //if (a == 9)
                //{
                //    a = 7;
                //}

                //if (a == 3)
                //{
                //    a = 1;
                //}   

                //if (a == 8)
                //{
                //    a = 6;
                //}
            }

//_____________________________________________________________________________________________________________________________________

            if (a == 1)
            {
                pictureBox1.Location=new Point(pictureBox1.Location.X, pictureBox1.Location.Y-10);
            }

            if (a == 2)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X-10, pictureBox1.Location.Y);
            }

            if (a == 3)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 10);
            }

            if (a == 4)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X+10, pictureBox1.Location.Y);
            }

            if (a == 6)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y - 10);
            }

            if (a == 7)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y - 10);
            }

            if (a == 8)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y + 10);
            }

            if (a == 9)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y + 10);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            scale2();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (a == 10)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y - 5);
                pictureBox1.Size = new Size(pictureBox1.Size.Width + 10, pictureBox1.Size.Height + 10);
            }

            if (a == 11)
            {
                if (pictureBox1.Location.X != 10 && pictureBox1.Location.Y != 10)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y + 5);
                    pictureBox1.Size = new Size(pictureBox1.Size.Width - 10, pictureBox1.Size.Height - 10);
                }
            }
        }
    }
}
