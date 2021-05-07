using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
   public  class Order : IComparable
    {

        // 订单ID 顾客 下单时间  配送地址
        public int OrderNum { get; set; }
        public string Customer { get; set; }
        public string OrderTime { get; set; }
        public string OrderAddress { get; set; }

        public List<OrderDetails> orderDe = new List<OrderDetails>();
        public List<OrderDetails> Orderde
        {
            get { return orderDe; }
        }
        public Order() { }
        public Order(int orderNum, string customer, string orderTime, string orderAddress)
        {
            OrderNum = orderNum;
            Customer = customer;
            OrderTime = orderTime;
            OrderAddress = orderAddress;
        }

        public int CompareTo(object obj)
        {
            Order a = obj as Order;
            return this.OrderNum.CompareTo(a.OrderNum);
        }

        public override bool Equals(object obj)
        {
            return obj is Order order && OrderNum == order.OrderNum;
        }

        public override int GetHashCode()
        {
            return 1 + OrderNum.GetHashCode();
        }

        public override string ToString()
        {
            string a = "";
            foreach (var temp in orderDe)
            {
                a = a + temp.ToString() + "\n";
            }
            return $"订单号为{OrderNum}，客户为{Customer}，订单时间为{OrderTime}，订单发送的地址为{OrderAddress} \n{a}";
        }
        //添加一个订单明细
        public void AddItems(OrderDetails a)
        {
            Boolean IsAdd = false;
            foreach (OrderDetails temp in orderDe)
            {
                if (a.Equals(temp))
                {
                    Console.WriteLine("商品已经存在，不需要添加");
                    IsAdd = true;
                }
            }
            if (IsAdd == false) orderDe.Add(a);
        }
        //计算总金额
        public double Sum()
        {
            double sum = 0;
            foreach (var temp in orderDe)
            {
                sum = sum + temp.Num * temp.Price;
            }
            return sum;
        }
        //移除一个订单明细
        public void Remove(string goods)
        {
            Boolean SuccessRemove = false;
            for (int i = 0; i < orderDe.Count; i++)
            {
                if (orderDe[i].Goods == goods)
                {
                    orderDe.Remove(orderDe[i]);
                    SuccessRemove = true;
                }
            }
            if (SuccessRemove == true)
            {
                Console.WriteLine($"订单中名为{goods}的商品移除成功");
            }
            else Console.WriteLine($"找不到名为{goods}的商品，移除失败");
        }

        public Boolean SelectGoods(string a)
        {
            Boolean b = false;
            foreach (var tem in orderDe)
            {
                if (tem.Goods == a) { b = true; }
            }

            return b;
        }
    }
}
