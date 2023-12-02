using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Mh(object sender, EventArgs e)
        {
        }
        public Random rnd = new Random();
        public async void harak(int x)
        {
            int xkordinat = rnd.Next(93, 1767);
            int ykordinat = rnd.Next(41, 894);
            await Task.Delay(x);

            button1.Location = new Point(xkordinat, ykordinat);
        }
        private void fm1_Ky(object sender, KeyEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            button1.Enabled = false;
            button3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Me(object sender, EventArgs e)
        {
            if(radioButton2.Checked == true)
            {
                harak(100);
            }
            else if (radioButton1.Checked == true)
            {
                harak(50);
            }
            else if(radioButton3.Checked == true) 
            { 
                harak(25);
            }
            else if(radioButton4.Checked == true)
            {
                harak(10);
            }
            else if(radioButton5.Checked == true)
            {
                harak(5);
            }
            else if(radioButton6.Checked == true)
            {
                harak(0);
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }


        }
        public int sayaç = 0;
        private void button1_Md(object sender, MouseEventArgs e)
        {
            if(e.Button  == MouseButtons.Left)
            {
                
                MessageBox.Show("Yakaldın Beni");
                sayaç++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            button2.Visible = false;
            button1.Visible = true;
            button1.Enabled = true;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            düz();
        }
        public void düz()
        {
            label1.Visible = true;
            label2.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
            radioButton6.Visible = true;
            button2.Visible = true;
            button1.Visible = false;
            button1.Enabled = false;
            button3.Visible = false;
        }

        private void fm1_Mh(object sender, EventArgs e)
        {
            if(sayaç == 1)
            {
                düz();
                sayaç = 0;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
