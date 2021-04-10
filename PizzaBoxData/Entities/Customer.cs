using System;
using System.Collections.Generic;

#nullable disable

namespace PizzaBoxData.Entities
{
    public partial class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Amout { get; set; }
        public int UpdateCounter { get; set; }
    }
}
