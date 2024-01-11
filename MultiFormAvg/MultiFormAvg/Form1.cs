using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFormAvg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] Numbers = new int[20];
        public int Count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Result result = new Result();
            int Num = int.Parse(textBox1.Text);
            if (Count <= Numbers.Length)
            {
                Numbers[Count] = Num;
                Count++;    
            }
            else
            {
                MessageBox.Show("Arry is Full!");
            }
            
            for (int i = 0; i < Count; i++)
            {
                result.listBox1.Items.Add(Numbers[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Result result = new Result();
            int sum = 0;
            for (int i = 0;i < Count;i++)
            {
                sum += Numbers[i];
            }
            int avg = sum / Count;
            result.label2.Text = avg.ToString();
            for (int i = 0; i < Count; i++)
            {
                result.listBox1.Items.Add(Numbers[i]);
            }
            result.Show();


        }
    }
}
