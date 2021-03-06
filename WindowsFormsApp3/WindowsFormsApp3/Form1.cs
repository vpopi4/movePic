using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        int a = 0;
        
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
      
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            a = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            a = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = 4;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           switch (a)
            {
                case 1:
            {
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 10);
                    pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 10);
                    pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y - 10);
                        break;
                }
                case 2:
                    {
                        pictureBox1.Location = new Point(pictureBox1.Location.X-10, pictureBox1.Location.Y);
                        if (pictureBox1.Location.Y!=pictureBox2.Location.Y)
                            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 10);
                        else
                            pictureBox2.Location = new Point(pictureBox2.Location.X-10, pictureBox2.Location.Y );
                        if (pictureBox2.Location.Y != pictureBox3.Location.Y)
                            pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y - 10);
                        else
                            pictureBox3.Location = new Point(pictureBox3.Location.X - 10, pictureBox3.Location.Y );
                        
                        break;
                    }
                case 4:
                    {
                        pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
                        if (pictureBox1.Location.Y != pictureBox2.Location.Y)
                            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 10);
                        else
                            pictureBox2.Location = new Point(pictureBox2.Location.X + 10, pictureBox2.Location.Y);
                        if (pictureBox2.Location.Y != pictureBox3.Location.Y)
                            pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y - 10);
                        else
                            pictureBox3.Location = new Point(pictureBox3.Location.X + 10, pictureBox3.Location.Y);

                        break;
                    }
            }
        }
    }
    }

