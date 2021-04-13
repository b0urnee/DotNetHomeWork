using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS
{
    [Serializable]
    public class OrderDetails
    {
        //物品，价格，数量
        public string Goods { get; set; }
        public double Price { get; set; }
        public int Num { get; set; }

        public OrderDetails(string goods, double price, int num)
        {
            this.Goods = goods;
            this.Price = price;
            this.Num = num;
        }

        public override bool Equals(object obj)
        {
            return obj is OrderDetails details && Goods == details.Goods;
        }

        public override int GetHashCode()
        {
            return 2 + EqualityComparer<string>.Default.GetHashCode(Goods);
        }

        public override string ToString()
        {
            return $"商品名称为{Goods},商品单价为{Price},商品数量为{Num}";
        }
    }
}
