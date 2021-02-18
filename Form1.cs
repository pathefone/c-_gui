using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string item;
        int quantity;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            item = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            quantity = int.Parse(textBox2.Text);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.chart1.Series["item_quantity"].Points.AddXY(item, quantity);
        }

    }
}
