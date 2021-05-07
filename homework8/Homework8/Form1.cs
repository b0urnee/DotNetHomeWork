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
    public partial class Form1 : Form
    {
       public  OrderService service = new OrderService();
       
        public Form1()
        {
            InitializeComponent();
            Order p1 = new Order(1, "小李", "2021.1.1", "湖南路22号");
            Order p2 = new Order(2, "小马", "2021.2.2", "中山路89号");
            Order p3 = new Order(3, "小王", "2021.3.5", "上海路23号");
            p1.AddItems(new OrderDetails("笔", 5.0, 1));
            p1.AddItems(new OrderDetails("本子", 10.0, 1));
            p2.AddItems(new OrderDetails("本子", 10.0, 1));
            p2.AddItems(new OrderDetails("笔盒", 20.0, 1));
            p3.AddItems(new OrderDetails("笔盒", 20.0, 1));
            p3.AddItems(new OrderDetails("书包", 100.0, 1));
            service.AddItems(p1);
            service.AddItems(p2);
            service.AddItems(p3);
            OrderBindingSource.DataSource = service.order;
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            switch (SearchWay.Text)
            {
                case"订单号":
                    OrderBindingSource.DataSource = service.SelectID(Convert.ToInt32(Searchtxt.Text));
                    break;
                case "客户名":
                    OrderBindingSource.DataSource = service.SelectName(Searchtxt.Text);
                    break;
                case "商品名":
                    OrderBindingSource.DataSource = service.SelectName(Searchtxt.Text);
                    break;
                default:
                    MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                    DialogResult  = MessageBox.Show("输入错误信息", "提示", messButton);
                    break;
            }
            
        }

        private void Return_Click(object sender, EventArgs e)
        {
             OrderBindingSource.DataSource = service.order;          
        }

        private void ROrder_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Owner = this;
            form2.TimeLab.DataBindings.Add("Text", OrderBindingSource, "OrderTime");
            form2.DetailView.DataSource = OrderDetailsBindingSource;
            form2.Address.DataBindings.Add("Text", OrderBindingSource, "OrderAddress");
            form2.OrderId.DataBindings.Add("Text", OrderBindingSource, "OrderNum");
            form2.OrderCus.DataBindings.Add("Text", OrderBindingSource, "Customer");
            form2.ShowDialog();
        }

        private void Addorder_Click(object sender, EventArgs e)
        {
            if (TxtID.Text == ""||TxtName.Text == ""||TxtAddress.Text == "")
            {
                MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                DialogResult  = MessageBox.Show("未填写正确的信息", "提示", messButton); }
            else
            {
                if (service.order.Contains(new Order(Convert.ToInt32(TxtID.Text), TxtName.Text, $"{DateTime.Now.Date}", TxtAddress.Text)))
                {
                    MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                    DialogResult = MessageBox.Show("此订单号已经存在", "提示", messButton);
                    return;
                }
                service.AddItems(new Order(Convert.ToInt32(TxtID.Text), TxtName.Text, $"{DateTime.Now.Date}", TxtAddress.Text));
                OrderBindingSource.ResetBindings(false);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            service.Remove(OrderBindingSource.Position+1);
            OrderBindingSource.ResetBindings(false);
        }

        public void AddDetail(string a,double b,int c)
        {
            if (OrderDetailsBindingSource.Contains(new OrderDetails(a, b, c))) {
                MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                DialogResult = MessageBox.Show("此商品已经存在", "提示", messButton);
            }
            else
            {
                OrderDetailsBindingSource.Add(new OrderDetails(a, b, c));
            }
        }
        public void DeleteDetail()
        {
            OrderDetailsBindingSource.RemoveCurrent();
            OrderBindingSource.ResetBindings(false);
        }

        private void OUTOrder_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                service.Exports(saveFileDialog1.FileName);
                MessageBox.Show("成功导出");
            }
        }

        private void INOrder_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                service.order = service.Imports(openFileDialog1.FileName);
                MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                DialogResult dr = MessageBox.Show("成功导入", "提示", messButton);
                if (dr == DialogResult.OK)
                {
                    OrderBindingSource.DataSource = service.order;
                }
            }
        }
    }
}
