using System;
using System.Collections.Generic;

#nullable disable

namespace PizzaBoxData.Entities
{
    public partial class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string StoreName { get; set; }
        public string PizzaName { get; set; }
        public string PizzaCrust { get; set; }
        public string PizzaSize { get; set; }
        public decimal Price { get; set; }
    }
}
