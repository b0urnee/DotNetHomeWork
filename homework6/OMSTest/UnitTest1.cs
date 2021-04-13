using Microsoft.VisualStudio.TestTools.UnitTesting;
using OMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OMSTest
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void AddItemsTest()
        {
            OrderService service = new OrderService();
            Order order = new Order(0, "Person", "12:00", "Any");
            service.AddItems(order);
            CollectionAssert.Contains(service.order, order);
        }

        [TestMethod()]
        public void AddItemsTest2()
        {
            OrderService service = new OrderService();
            Order order = new Order(0, "Person", "12:00", "Any");
            service.AddItems(order);
            service.AddItems(order);
            CollectionAssert.AllItemsAreUnique(service.order);
        }

        [TestMethod()]
        public void AddItemsTest3()
        {
            OrderService service = new OrderService();
            Order order = null;
            service.AddItems(order);
            CollectionAssert.AllItemsAreNotNull(service.order);
        }

        [TestMethod()]
        public void RemoveTest()
        {
            OrderService service = new OrderService();
            Order order1 = new Order(0, "Person", "12:00", "Any");
            Order order2 = new Order(1, "Person2", "12:00", "Any");
            service.AddItems(order1);
            service.AddItems(order2);
            service.Remove(0);
            CollectionAssert.DoesNotContain(service.order, order1);
            service.Remove(3);
            CollectionAssert.Contains(service.order, order2);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            OrderService service = new OrderService();
            Order order1 = new Order(0, "Person", "12:00", "Any");
            service.AddItems(order1);
            string a = order1.ToString() + " 总金额为" + order1.Sum() + "\n\n";
            Assert.AreEqual(service.ToString(), a);
        }

        [TestMethod()]
        public void SelectIDTest()
        {
            OrderService service = new OrderService();
            Order order1 = new Order(0, "Person", "12:00", "Any");
            Order order2 = new Order(1, "Person2", "12:00", "Any");
            service.AddItems(order1);
            service.AddItems(order2);
            List<Order> Testlist = new List<Order>() { order1 };
            CollectionAssert.AreEqual(Testlist, service.SelectID(0));
            Assert.IsNull(service.SelectID(3));

        }

        [TestMethod()]
        public void SelectSumTest()
        {
            OrderService service = new OrderService();
            Order order1 = new Order(0, "Person", "12:00", "Any");
            Order order2 = new Order(1, "Person2", "12:00", "Any");
            OrderDetails g1 = new OrderDetails("笔", 5.0, 1);
            OrderDetails g2 = new OrderDetails("本子", 10.0, 1);
            order1.AddItems(g1);
            order2.AddItems(g2);
            service.AddItems(order1);
            service.AddItems(order2);
            List<Order> Testlist = new List<Order>() { order1 };
            CollectionAssert.AreEqual(Testlist, service.SelectSum(5));
            Assert.IsNull(service.SelectSum(15));
        }

        [TestMethod()]
        public void SelectNameTest()
        {
            OrderService service = new OrderService();
            Order order1 = new Order(0, "Person", "12:00", "Any");
            Order order2 = new Order(1, "Person2", "12:00", "Any");
            service.AddItems(order1);
            service.AddItems(order2);
            List<Order> Testlist = new List<Order>() { order1 };
            CollectionAssert.AreEqual(Testlist, service.SelectName("Person"));
            Assert.IsNull(service.SelectName("Person3"));
        }
        [TestMethod()]
        public void ImportTest()
        {
            OrderService service = new OrderService();
            Order order1 = new Order(0, "Person", "12:00", "Any");
            service.AddItems(order1);
            service.Export("s.xml");
            //string b = service.Imports("b.xml"); 
            string a = service.Import("s.xml");
            Assert.AreEqual(a, order1.ToString());
        }
    }
}
