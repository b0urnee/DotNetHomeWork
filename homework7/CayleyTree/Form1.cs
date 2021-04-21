using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            drawCayleyTree(depth, 200, 310, length, -Math.PI / 2);
        }

        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;    //右分支角度
        double th2 = 20 * Math.PI / 180;    //左分支角度
        double per1 = 0.6;  //右分支比
        double per2 = 0.7;  //左分支比
        int depth = 10; //递归深度
        int length = 100;   //主干长度
        string color = "";  //颜色

        void drawCayleyTree(int depth, double x0, double y0, double length, double th)
        {
            if (depth == 0) return;

            double x1 = x0 + length * Math.Cos(th);
            double y1 = y0 + length * Math.Sin(th);

            drawLine(x0, y0, x1, y1, color);

            drawCayleyTree(depth - 1, x1, y1, per1 * length, th + th1);
            drawCayleyTree(depth - 1, x1, y1, per2 * length, th - th2);
        }

        void drawLine(double x0, double y0, double x1, double y1, string color)
        {
            switch (color)
            {
                case "blue": graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1); break;
                case "yellow": graphics.DrawLine(Pens.Yellow, (int)x0, (int)y0, (int)x1, (int)y1); break;
                case "green": graphics.DrawLine(Pens.Green, (int)x0, (int)y0, (int)x1, (int)y1); break;
                case "red": graphics.DrawLine(Pens.Red, (int)x0, (int)y0, (int)x1, (int)y1); break;
                default: graphics.DrawLine(Pens.Black, (int)x0, (int)y0, (int)x1, (int)y1); break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            depth = int.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            length = int.Parse(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            per1 = double.Parse(textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            per2 = double.Parse(textBox4.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            th1 = double.Parse(textBox5.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            th2 = double.Parse(textBox6.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            color = comboBox1.Text;
        }
    }
}
