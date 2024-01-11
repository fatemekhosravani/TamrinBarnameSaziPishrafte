using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string num = textBox1.Text;
                int n = int.Parse(num);
                int x;
                n = n - 1;
                if (n < 1)
                {
                    MessageBox.Show("Write Number greter Than Ziro");
                    return;
                }
                x = fib(n);
                MessageBox.Show("Member Of  " + (n + 1) + " Is:" + x.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private static int fib(int n)
        {
            if (n <= 0)
                return n;
            if (n == 1)
                return n;
            else
                return fib(n - 1) + fib(n - 2);
        }

    }
}

