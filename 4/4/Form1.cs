using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int X = Convert.ToInt32(textBox1.Text);

            int Y = Convert.ToInt32(textBox2.Text);

            int E = Convert.ToInt32(textBox3.Text);

            if (Y < X)
            {
                double Z = Y * Math.Pow(E, X);

                textBox4.Text = Z.ToString();
            }
            else if (Y == X)
            {
                double Z = Y * X;

                textBox4.Text = Z.ToString();
            }
            else if (Y > X)
            {
                double Z = X * Math.Pow(E, Y);

                textBox4.Text = Z.ToString();
            }
            else
            {
                textBox4.Text = ("Порожня множина");
            }
        }
    }
}
