using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wyszukiwanie.Properties;

namespace wyszukiwanie
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
        

        private void Form1_Load(object sender, EventArgs e)
        {
            int a = new Random().Next(1, 6);
            pictureBox1.Image = imageList1.Images[a];
            label6.Text = a.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            int a = new Random().Next(1, 6);
            pictureBox1.Image = imageList1.Images[a];
            label6.Text = a.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = int.Parse(label6.Text);
            switch (c)
            {
                case 0:
                    if(captchatxt.Text == "befbd")
                    {
                        break;
                    }
                    else
                    {
                        return;
                    }
                case 1:
                    if(captchatxt.Text == "x3deb")
                    {
                        break;
                    }
                    else
                    {
                        return;
                    }
                case 2:
                    if (captchatxt.Text == "cg5dd")
                    {
                        break;
                    }
                    else
                    {
                        return;
                    }
                case 3:
                    if (captchatxt.Text == "74853")
                    {
                        break;
                    }
                    else
                    {
                        return;
                    }
                case 4:
                    if (captchatxt.Text == "b5nmm")
                    {
                        break;
                    }
                    else
                    {
                        return;
                    }
                case 5:
                    if (captchatxt.Text == "mxyw")
                    {
                        break;
                    }
                    else
                    {
                        return;
                    }
            }
            
            if (imietxt.Text == "admin" && haslotxt.Text == "Qwerty1@34"){
                MessageBox.Show("Zalogowano");
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
        }
    }
}
