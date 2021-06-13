using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
   public  class OrderDetails
    {
        [Key]
        public string Goods { get; set; }

        public double Price { get; set; }
        public int Num { get; set; }
   
        public int OrderID { get; set; }
        public Order order { get; set; }
    }
}
