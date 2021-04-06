using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService service = new OrderService();
            Order p1 = new Order(14860231, "小李", "2021.1.1", "湖南路22号");
            Order p2 = new Order(31232144, "小马", "2021.2.2", "中山路89号");
            Order p3 = new Order(11234254, "小王", "2021.3.5", "上海路23号");
            OrderDetails g1 = new OrderDetails("水杯", 5.0, 1);
            OrderDetails g2 = new OrderDetails("椅子", 10.0, 1);
            OrderDetails g3 = new OrderDetails("台灯", 20.0, 1);
            OrderDetails g4 = new OrderDetails("书包", 100.0, 1);
            p1.AddItems(g1);
            p1.AddItems(g2);
            p2.AddItems(g3);
            p2.AddItems(g4);
            p3.AddItems(g1);
            p3.AddItems(g3);
            service.AddItems(p1);
            service.AddItems(p2);
            Console.WriteLine("订单情况：\n" + service.ToString());
            service.AddItems(p3);
            Console.WriteLine("增加一个订单后：\n" + service.ToString());
            service.Remove(31232144);
            Console.WriteLine("删除一个订单后：\n" + service.ToString());
            Console.WriteLine();
        }
    }
}
