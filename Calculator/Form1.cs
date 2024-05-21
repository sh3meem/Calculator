using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalTotal;
        int num1;
        int num2;
        string option;
        int result;

        private void button4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn5.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn7.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn9.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn0.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn1.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn6.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn3.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn8.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtTotal.Text);

            if(option.Equals("+")) 
                result = num1+num2;

            if (option.Equals("-"))
                result = num1 + num2;

            if (option.Equals("*"))
                result = num1 + num2;

            if (option.Equals("/"))
                result = num1 + num2;

            txtTotal.Text = result + "";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            result = (0);
            num1 = (0); 
            num2 = (0);
        }
    }
}
