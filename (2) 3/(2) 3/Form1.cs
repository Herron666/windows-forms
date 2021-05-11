using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2__3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1);

            int i = 3;

            double f = 0;

            double ff = 9;

            double fff = 9;

            double ffff = 0;

            if (n >= 3)
            {
                while (i <= n)
                {
                    ffff = fff + ff + f;

                    f = ff;

                    ff = fff;

                    fff = ffff;

                    i++;
                }
                double d = ffff;

                textBox2.Text = d.ToString();
            }
            else if (0 < n || n <= 2)
            {
                textBox2.Text = ("Результат = 9");
            }
            else if (n == 0)
            {
                textBox2.Text = ("Результат = 0");
            }
            else
            {
                textBox2.Text = ("Error");
            }
        }
    }
}
