using System;
using System.Collections.Generic;

#nullable disable

namespace PizzaBoxData.Entities
{
    public partial class SizeInfo
    {
        public SizeInfo()
        {
            OrderInfo2s = new HashSet<OrderInfo2>();
            OrderInfo3s = new HashSet<OrderInfo3>();
        }

        public int SizeId { get; set; }
        public string SizeName { get; set; }
        public decimal? SizePrice { get; set; }

        public virtual ICollection<OrderInfo2> OrderInfo2s { get; set; }
        public virtual ICollection<OrderInfo3> OrderInfo3s { get; set; }
    }
}
