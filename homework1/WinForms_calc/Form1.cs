using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_calc
{
    public partial class 简易计算器 : Form
    {
        double operand1, operand2;
        string op;

        public 简易计算器()
        {
            InitializeComponent();
        }

        private void 简易计算器_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            operand2 = double.Parse(textBox2.Text);
        }

       /* private void ComboBoxForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(" + ");
            comboBox1.Items.Add(" - ");
            comboBox1.Items.Add(" * ");
            comboBox1.Items.Add(" / ");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            op = (string)comboBox1.Text;
            *//*if (op == "+") MessageBox.Show($"{operand1 + operand2}");
            if (op == "-") MessageBox.Show($"{operand1 - operand2}");
            if (op == "*") MessageBox.Show($"{operand1 * operand2}");
            if (op == "/") MessageBox.Show($"{operand1 / operand2}");*//*
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            if (op == "+") MessageBox.Show($"{operand1 + operand2}", "结果");
            if (op == "-") MessageBox.Show($"{operand1 - operand2}", "结果");
            if (op == "*") MessageBox.Show($"{operand1 * operand2}", "结果");
            if (op == "/") MessageBox.Show($"{operand1 / operand2}", "结果");
        }

        private void comboBox1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(" + ");
            comboBox1.Items.Add(" - ");
            comboBox1.Items.Add(" * ");
            comboBox1.Items.Add(" / ");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            op = (string)comboBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            operand1 = double.Parse(textBox1.Text);
        }
    }
}
