using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework8
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {  
            InitializeComponent();
        }
        

        private void Restore_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
        }

        private void AddDetail_Click(object sender, EventArgs e)
        {
            if (GoodsName.Text == "" || GoodsNum.Text == "" || GoodsPrice.Text == "")
            {
                MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                DialogResult = MessageBox.Show("商品信息未填写完整", "提示", messButton);
            }
            else
            {
                MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                DialogResult dr = MessageBox.Show("是否确定要添加此商品", "提示", messButton);
                if (dr == DialogResult.OK)
                {
                    Form f = this.Owner;
                    ((Form1)f).AddDetail(this.GoodsName.Text, Convert.ToDouble(this.GoodsPrice.Text), Convert.ToInt32(this.GoodsNum.Text));
                }
            }
        }

        private void DeleteDetail_Click(object sender, EventArgs e)
        {
            Form f = this.Owner;
            ((Form1)f).DeleteDetail();
        }
    }
}
