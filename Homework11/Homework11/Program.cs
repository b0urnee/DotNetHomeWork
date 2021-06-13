using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Homework11
{
    class Program
    {
        static void AddDetail(OrderDetails a)
        {
            using (var context = new OrderConnext())
            {
                context.Entry(a).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        static void AddOrder(Order a)
        {
            using (var context = new OrderConnext())
            {
                context.orders.Add(a);
                context.SaveChanges();
            }
        }

        static void DeleteOrder(int i)
        {
            using (var context= new OrderConnext())
            {
                var order = context.orders.Include(b=>b.orderDe).FirstOrDefault(o => o.OrderID == i);
                if(order != null)
                {
                    context.orders.Remove(order);
                    context.SaveChanges();
                }
            }
        }

        static void Select(int i)
        {
            using (var context = new OrderConnext())
            {
                var order = context.orders.SingleOrDefault(b => b.OrderID == i);
                if (order != null) { Console.WriteLine(order.ToString()); }
            }
        }

        static void Exports(string a)
        {
            using (var context = new OrderConnext())
            {
                
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
                using (FileStream fileStream = new FileStream(a, FileMode.Create))
                {                 
                    xmlSerializer.Serialize(fileStream, context.orders.ToList());
                }
            }
        }

        static List<Order> Imports(string b)
        {
            List<Order> orders;
            using (FileStream fs = new FileStream(b, FileMode.Open))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
                orders = (List<Order>)xmlSerializer.Deserialize(fs);
            }
            return orders;
        }

        static void Main(string[] args)
        {
            //初始化
            using (var context = new OrderConnext())
            {
                var order1 = new Order() { OrderID=1, Customer = "小李", OrderAddress = "whu", OrderTime = "2021.5.5" };
                order1.orderDe = new List<OrderDetails>()
                {
                    new OrderDetails(){Goods="笔",Num=1,Price=5}
                };
                context.orders.Add(order1);
                context.SaveChanges();
            }

            //添加一个订单明细
            AddDetail(new OrderDetails() { Goods = "书包1", Num = 1, Price = 50, OrderID = 1 });
            //添加一个订单
            AddOrder(new Order() { OrderID = 2, Customer = "小张", OrderAddress = "zju", OrderTime = "2021.5.5" });
            AddDetail(new OrderDetails() { Goods = "书包2", Num = 1, Price = 50, OrderID = 2});
            //删除一个指定订单号的订单及其明细
            //DeleteOrder(2);
            //查询指定订单号的订单
            Select(1);
            //导出不完整
            Exports("a");
            //导入
            using (var context = new OrderConnext())
            {
                //有点问题
               // context.orders = Imports("a");
            }
        }
    }
}
