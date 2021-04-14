using System;
using System.Collections.Generic;

#nullable disable

namespace PizzaBoxData.Entities
{
    public partial class ToppingInfo
    {
        public ToppingInfo()
        {
            OrderInfo2Top1Navigations = new HashSet<OrderInfo2>();
            OrderInfo2Top2Navigations = new HashSet<OrderInfo2>();
            OrderInfo2Top3Navigations = new HashSet<OrderInfo2>();
            OrderInfo2Top4Navigations = new HashSet<OrderInfo2>();
            OrderInfo2Top5Navigations = new HashSet<OrderInfo2>();
        }

        public int ToppingId { get; set; }
        public string ToppingName { get; set; }

        public virtual ICollection<OrderInfo2> OrderInfo2Top1Navigations { get; set; }
        public virtual ICollection<OrderInfo2> OrderInfo2Top2Navigations { get; set; }
        public virtual ICollection<OrderInfo2> OrderInfo2Top3Navigations { get; set; }
        public virtual ICollection<OrderInfo2> OrderInfo2Top4Navigations { get; set; }
        public virtual ICollection<OrderInfo2> OrderInfo2Top5Navigations { get; set; }
    }
}
