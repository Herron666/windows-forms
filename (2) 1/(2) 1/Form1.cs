using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2__1
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
            int n = 12;

            double a = Convert.ToDouble(textBox1);

            double f = 0;

            int i = 1;

            while (n >= i)
            {
                double ff = f - Math.Cos(Math.Pow(a, i) / 12);

                f = ff;

                i++;
            }

            textBox2.Text = f.ToString();
        }
    }
}
