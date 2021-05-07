using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Homework8
{
    public class OrderService
    {
        public List<Order> order = new List<Order>();
        
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));

        public OrderService() { }
        public void AddItems(Order p)
        {
            Boolean Isadd = false;
            if (p == null) Isadd = true;
            foreach (var temp in order)
            {
                if (temp.Equals(p))
                {
                    Console.WriteLine("此订单号已经存在");
                    Isadd = true; 
                }
            }
            if (Isadd == false) order.Add(p);
        }

        public void Remove(int a)
        {
            Boolean SuccessRemove = false;
            for (int i = 0; i < order.Count; i++)
            {
                if (order[i].OrderNum == a)
                {
                    order.Remove(order[i]);
                    SuccessRemove = true;
                }
            }
            if (SuccessRemove == true)
            {
                Console.WriteLine($"订单号为{a}的商品移除成功");
            }
            else Console.WriteLine($"找不到订单号为{a}的商品，移除失败");
        }

        public override string ToString()
        {
            string a = "";
            foreach (var temp in order)
            {
                a = a + temp.ToString() + " 总金额为" + temp.Sum() + "\n\n";
            }
            return a;
        }

        public List<Order> SelectID(int a)
        {
            if (a > order.Count || a < 0)
            {
                Console.WriteLine("输入的订单号不存在");
                return null;
            }
            else
            {
                var query = from s in order
                            where a == s.OrderNum
                            orderby s.Sum()
                            select s;
                List<Order> list = query.ToList();
                foreach (var temp in list)
                {
                    Console.WriteLine(temp.ToString() + "总金额为" + temp.Sum() + "\n");
                }
                return list;
            }

        }

        public List<Order> SelectSum(int a)
        {
            var query = from s in order
                        where a == s.Sum()
                        orderby s.Sum()
                        select s;
            List<Order> list = query.ToList();
            if (list.Count == 0) { Console.WriteLine("找不到指定金额的订单"); return null; }
            else
            {
                foreach (var temp in list)
                {
                    Console.WriteLine(temp.ToString() + "总金额为" + temp.Sum() + "\n");
                }
            }
            return list;
        }

        public List<Order> SelectName(string a)
        {
            var query = from s in order
                        where a == s.Customer || s.SelectGoods(a)
                        orderby s.Sum()
                        select s;
            List<Order> list = query.ToList();
            if (list.Count == 0) { Console.WriteLine("找不到指定名称的订单"); return null; }
            else
            {
                foreach (var temp in list)
                {
                    Console.WriteLine(temp.ToString() + "总金额为" + temp.Sum() + "\n");
                }
            }
            return list;
        }

        public void Exports(string a)
        {
            using (FileStream fileStream = new FileStream(a, FileMode.Create))
            {
                xmlSerializer.Serialize(fileStream, order);
            }
        }
        public List<Order> Imports(string b)
        {
            List<Order> orders;
            using (FileStream fs = new FileStream(b, FileMode.Open)) 
            {                
                 orders = (List<Order>)xmlSerializer.Deserialize(fs);
            }
            return orders ;
        }
    }
}
