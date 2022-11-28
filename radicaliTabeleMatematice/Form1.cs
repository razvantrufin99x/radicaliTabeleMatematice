using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radicaliTabeleMatematice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            { 
                this.textBox1.Text += "\r\n";
                this.textBox1.Text += i.ToString() + "     ";
                this.textBox1.Text += Math.Sqrt(i).ToString();

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n;
            for (int i = 0; i <= 30; i++)
            {
                this.textBox2.Text += "\r\n";
                for (int j = 0; j <= 30; j++)
                {
                    this.textBox2.Text += "  ";
                    n = i * j;
                    this.textBox2.Text += n.ToString();
                    this.Refresh();
                }
            }
        }
    }
}
