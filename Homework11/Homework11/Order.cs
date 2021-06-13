using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
   public  class Order
    {
        [Key]
        public int OrderID { get; set; }

        public string Customer { get; set; }
        public string OrderTime { get; set; }
        public string OrderAddress { get; set; }
        public List<OrderDetails> orderDe { get; set; }

        public override string ToString()
        {
            return OrderID+" "+Customer+" "+OrderTime+" "+OrderAddress;
        }
    }
}
