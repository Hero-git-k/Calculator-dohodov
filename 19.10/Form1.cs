using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int c;
            int s;
            int d;
            a = Convert.ToInt32(textBox3.Text); 
            b = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox1.Text);
            d = (c/100);
            s = ((a*(1+d/12))^b);
            textBox4.Text = Convert.ToString(s);
        }
    }
}
