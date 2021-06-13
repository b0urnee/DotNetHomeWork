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
   
     public class OrderConnext:DbContext
    {
        public OrderConnext() : base("OrderDataBase")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<OrderConnext>());
        }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderDetails> orderDetails { get; set; }

    }

}
