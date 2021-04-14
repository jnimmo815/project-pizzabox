using System;
using System.Collections.Generic;

#nullable disable

namespace PizzaBoxData.Entities
{
    public partial class OrderInfo2
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string StroreName { get; set; }
        public string PizzaName { get; set; }
        public int CrustType { get; set; }
        public int SizeType { get; set; }
        public int? Top1 { get; set; }
        public int? Top2 { get; set; }
        public int? Top3 { get; set; }
        public int? Top4 { get; set; }
        public int? Top5 { get; set; }

        public virtual CrustInfo CrustTypeNavigation { get; set; }
        public virtual SizeInfo SizeTypeNavigation { get; set; }
        public virtual ToppingInfo Top1Navigation { get; set; }
        public virtual ToppingInfo Top2Navigation { get; set; }
        public virtual ToppingInfo Top3Navigation { get; set; }
        public virtual ToppingInfo Top4Navigation { get; set; }
        public virtual ToppingInfo Top5Navigation { get; set; }
    }
}
