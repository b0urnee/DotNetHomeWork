using System;
using System.Collections.Generic;
using System.Text;

namespace OMS
{
    [Serializable]
    public class Order
    {
        //订单号，顾客，数量，下单时间，配送地址
        public int OrderNum { get; set; }
        public string Customer { get; set; }
        public string OrderTime { get; set; }
        public string OrderAddress { get; set; }

        public Order(int orderNum, string customer, string orderTime, string orderAddress)
        {
            this.OrderNum = orderNum;
            this.Customer = customer;
            this.OrderTime = orderTime;
            this.OrderAddress = orderAddress;
        }

        public List<OrderDetails> orderDetails = new List<OrderDetails>();

        public override bool Equals(object obj)
        {
            return obj is Order order && OrderNum == order.OrderNum;
        }
        public int CompareTo(object obj)
        {
            Order tmp = obj as Order;
            return this.OrderNum.CompareTo(tmp.OrderNum);
        }
        public override int GetHashCode()
        {
            return OrderNum.GetHashCode() + 1;
        }
        public Boolean SelectGoods(string a)
        {
            Boolean b = false;
            foreach (var tem in orderDetails)
            {
                if (tem.Goods == a) { b = true; }
            }

            return b;
        }
        public override string ToString()
        {
            return $"订单号为{OrderNum},顾客是{Customer},下单时间{OrderTime},配送地址{OrderAddress}";
        }

        //增添
        public void AddItems(OrderDetails a)
        {
            Boolean IsAdd = false;
            foreach (OrderDetails temp in orderDetails)
            {
                if (a.Equals(temp))
                {
                    Console.WriteLine("商品已经存在，不需要添加");
                    IsAdd = true;
                }
            }
            if (IsAdd == false) orderDetails.Add(a);
        }
        //移除一个订单明细
        public void Remove(string goods)
        {
            Boolean SuccessRemove = false;
            for (int i = 0; i < orderDetails.Count; i++)
            {
                if (orderDetails[i].Goods == goods)
                {
                    orderDetails.Remove(orderDetails[i]);
                    SuccessRemove = true;
                }
            }
            if (SuccessRemove == true)
            {
                Console.WriteLine($"订单中名为{goods}的商品移除成功");
            }
            else Console.WriteLine($"找不到名为{goods}的商品，移除失败");
        }
        //计算总金额
        public double Sum()
        {
            double sum = 0;
            foreach (var temp in orderDetails)
            {
                sum = sum + temp.Num * temp.Price;
            }
            return sum;
        }
    }
}
