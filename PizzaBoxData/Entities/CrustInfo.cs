using System;
using System.Collections.Generic;

#nullable disable

namespace PizzaBoxData.Entities
{
    public partial class CrustInfo
    {
        public CrustInfo()
        {
            OrderInfo2s = new HashSet<OrderInfo2>();
            OrderInfo3s = new HashSet<OrderInfo3>();
        }

        public int CrustId { get; set; }
        public string CrustName { get; set; }
        public decimal? CrustPrice { get; set; }

        public virtual ICollection<OrderInfo2> OrderInfo2s { get; set; }
        public virtual ICollection<OrderInfo3> OrderInfo3s { get; set; }
    }
}
