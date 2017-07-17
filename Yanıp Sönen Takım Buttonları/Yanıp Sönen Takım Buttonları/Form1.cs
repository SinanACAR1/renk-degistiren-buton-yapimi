using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Yanıp_Sönen_Takım_Buttonları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int süre = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            süre++;
            label1.Text = süre.ToString();
            if (checkBox1.Checked == true)
            {
                if (süre % 10 == 0)
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Yellow;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Yellow;
                    button5.BackColor = Color.Red;
                    button6.BackColor = Color.Yellow;
                    button7.BackColor = Color.Red;
                    button8.BackColor = Color.Yellow;

                }
                if (süre % 10 == 5)
                {
                    button1.BackColor = Color.Yellow;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Yellow;
                    button4.BackColor = Color.Red;
                    button5.BackColor = Color.Yellow;
                    button6.BackColor = Color.Red;
                    button7.BackColor = Color.Yellow;
                    button8.BackColor = Color.Red;
                }

            }
            if (checkBox2.Checked == true)
            {


                if (süre % 10 == 0)
                {
                    button1.BackColor = Color.Navy;
                    button2.BackColor = Color.Yellow;
                    button3.BackColor = Color.Navy;
                    button4.BackColor = Color.Yellow;
                    button5.BackColor = Color.Navy;
                    button6.BackColor = Color.Yellow;
                    button7.BackColor = Color.Navy;
                    button8.BackColor = Color.Yellow;
                }
                if (süre % 10 == 5)
                {
                    button1.BackColor = Color.Yellow;
                    button2.BackColor = Color.Navy;
                    button3.BackColor = Color.Yellow;
                    button4.BackColor = Color.Navy;
                    button5.BackColor = Color.Yellow;
                    button6.BackColor = Color.Navy;
                    button7.BackColor = Color.Yellow;
                    button8.BackColor = Color.Navy;

                }
            }

                if (checkBox3.Checked == true)
                {

                    if (süre % 10 == 0)
                    {
                        button1.BackColor = Color.Black;
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.Black;
                        button4.BackColor = Color.White;
                        button5.BackColor = Color.Black;
                        button6.BackColor = Color.White;
                        button7.BackColor = Color.Black;
                        button8.BackColor = Color.White;
                    }
                    if (süre % 10 == 5)
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.Black;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.Black;
                        button5.BackColor = Color.White;
                        button6.BackColor = Color.Black;
                        button7.BackColor = Color.White;
                        button8.BackColor = Color.Black;
                    }
                }
                if (checkBox4.Checked == true)
                {
                    if (süre % 10 == 0)
                    {
                        button1.BackColor = Color.DarkRed;
                        button2.BackColor = Color.Blue;
                        button3.BackColor = Color.DarkRed;
                        button4.BackColor = Color.Blue;
                        button5.BackColor = Color.DarkRed;
                        button6.BackColor = Color.Blue;
                        button7.BackColor = Color.DarkRed;
                        button8.BackColor = Color.Blue;
                    }
                    if (süre % 10 == 5)
                    {
                        button1.BackColor = Color.Blue;
                        button2.BackColor = Color.DarkRed;
                        button3.BackColor = Color.Blue;
                        button4.BackColor = Color.DarkRed;
                        button5.BackColor = Color.Blue;
                        button6.BackColor = Color.DarkRed;
                        button7.BackColor = Color.Blue;
                        button8.BackColor = Color.DarkRed;
                    }
                }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            süre = 0;
            timer1.Start();
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            süre = 0;
            timer1.Start();
            checkBox1.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            süre = 0;
            timer1.Start();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            süre = 0;
            timer1.Start();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }
    }
}

