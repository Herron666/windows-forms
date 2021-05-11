using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(textBox1);

            int y1 = Convert.ToInt32(textBox2);

            int x2 = Convert.ToInt32(textBox3);

            int y2 = Convert.ToInt32(textBox4);           

            int x3 = Convert.ToInt32(textBox5);

            int y3 = Convert.ToInt32(textBox6);

            double AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            double AC = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

            double BC = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));

            if (AB == AC || AC == BC || BC == AB)
            {
               textBox7.Text = ("Буде рівнобедреним");
            }
            else
            {
               textBox7.Text = ("не буде рівнобедреним");
            }
        }
    }
}
