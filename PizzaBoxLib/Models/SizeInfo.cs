using System;

namespace PizzaBoxLib.Models
{
  public partial class SizeInfo
  {
    // public SizeInfo()
    // {
    //   OrderInfo3s = new HashSet<OrderInfo3>();
    // }

    public int SizeId { get; set; }
    public string SizeName { get; set; }
    public decimal? SizePrice { get; set; }

    // public virtual ICollection<OrderInfo3> OrderInfo3s { get; set; }
  }
}