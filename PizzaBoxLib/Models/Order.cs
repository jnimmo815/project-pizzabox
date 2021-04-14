using System;
using System.Collections.Generic;

#nullable disable

namespace PizzaBoxLib.Models
{
  public partial class Order
  {
    public int Id { get; set; }
    public string UserName { get; set; }
    public string StroreName { get; set; }
    public string PizzaName { get; set; }
    public string CrustName { get; set; }
    public int SizeName { get; set; }
    public decimal? PizzaPrice { get; set; }
    public DateTime? OrderTime { get; set; }
  }
}