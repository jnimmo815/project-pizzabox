using System;
using System.Collections.Generic;

#nullable disable

namespace PizzaBoxData.Entities
{
    public partial class SuperHero
    {
        public decimal Id { get; set; }
        public string RealName { get; set; }
        public string Alias { get; set; }
        public string HideOut { get; set; }
    }
}
