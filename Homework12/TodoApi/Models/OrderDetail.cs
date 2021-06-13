using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public string Goods { get; set; }
        public double Price { get; set; }
        public int Num { get; set; }

        public int OrderID { get; set; }
        public Order order { get; set; }
    }
}
