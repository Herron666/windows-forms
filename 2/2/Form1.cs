using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);

            int b = Convert.ToInt32(textBox2.Text);

            int c = Convert.ToInt32(textBox3.Text);

            if (3 <= a && a <= 9)

            {
                textBox4.Text = ("а належить z");
            }
            else if (b <= a && a <= c)
            {
                textBox4.Text = ("а належить z");
            }
            else
            {
                textBox4.Text = ("а не належить z");
            }
        }
    }
}
