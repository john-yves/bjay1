using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp60
{
    public partial class Formcaculatel : Form
    {
        public Formcaculatel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a,b;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            textBox3.Text = Convert.ToString(Class1.Add(a, b));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            textBox3.Text = Convert.ToString(Class1.Sub(a, b));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            textBox3.Text=Convert.ToString(Class1.Times(a,b));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            textBox3.Text = Convert.ToString(Class1.Divide(a, b));
        }
    }
}
