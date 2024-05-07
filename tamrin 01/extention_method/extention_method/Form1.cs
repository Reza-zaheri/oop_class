using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace extention_method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                number num = new number();
                num.num1 = int.Parse(textBox1.Text);
                num.num2 = int.Parse(textBox2.Text);
                label4.Text = num.GetSum();
            }
            catch
            {
                label3.Text = "لطفا عدد وارد کنید";
                label3.ForeColor = Color.Red;
            }
        }
    }
}
