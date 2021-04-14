using System;
using System.Collections.Generic;

namespace PizzaBoxLib.Models
{
  public class MyOrder
  {
    public int Id { get; set; }
    public string UserName { get; set; }
    public string StoreName { get; set; }
    public string PizzaName { get; set; }
    public string CrustName { get; set; }
    public string SizeName { get; set; }
    public decimal? CrustPrice { get; set; }
    public decimal? SizePrice { get; set; }
    public DateTime? OrderTime { get; set; }
  }
}
