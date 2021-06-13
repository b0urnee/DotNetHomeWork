using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TodoApi.Models
{
    public class Order
    {   
        public int ID { get; set; }
        public string Customer { get; set; }
        public string OrderTime { get; set; }
        public string OrderAddress { get; set; }
        public List<OrderDetail> orderDe { get; set; }

        public override string ToString()
        {
            return ID + " " + Customer + " " + OrderTime + " " + OrderAddress;
        }
    }
}
