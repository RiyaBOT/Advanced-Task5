using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartApi.Models
{
    public class CartItem
    {
        public long Id { get; set; }

        public long Cart_ID { get; set; }

        public long Product_ID { get; set; }
        public string Order_Status { get; set; }

        public long Order_ID { get; set; }
        public long Total { get; set; }

        public long Product_Prices { get; set; }
    }
}