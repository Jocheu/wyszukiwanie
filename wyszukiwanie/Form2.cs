using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wyszukiwanie
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int czegoszukam = comboBox1.SelectedIndex + 1;
            string doczegoprownam = textBox1.Text;
            int jakSprawdzam = comboBox2.SelectedIndex;
            string[] uczen;
            richTextBox1.Text = "";
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\student\Downloads\uczen.txt");
            foreach (string line in lines)
            {
                uczen = line.Split(';');
                switch (jakSprawdzam)
                {
                    case 0:
                        if (uczen[czegoszukam] == doczegoprownam)
                        {
                            richTextBox1.Text += line + "\n";
                        }
                        break;
                    case 1:
                        if (uczen[czegoszukam].StartsWith(doczegoprownam))
                        {
                            richTextBox1.Text += line + "\n";
                        }
                        break;
                    case 2:
                        if (uczen[czegoszukam].Contains(doczegoprownam))
                        {
                            richTextBox1.Text += line + "\n";
                        }
                        break;
                }
                
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\student\Downloads\uczen.txt");
            string[] uczen = lines[lines.Length-1].Split(';');
            int numer = int.Parse(uczen[0]) +1;
            string nowynum = numer.ToString("D3");
            
            using (StreamWriter sw = File.AppendText(@"C:\Users\student\Downloads\uczen.txt"))
            {
                sw.WriteLine("\n" + nowynum + ";" + textBox2.Text + ";" + textBox3.Text + ";" + textBox4.Text);
                sw.Close();
            }
            MessageBox.Show("Dodano ucznia");
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
