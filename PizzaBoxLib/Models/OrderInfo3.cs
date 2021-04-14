using System;

namespace PizzaBoxLib.Models
{
  public class OrderInfo3
  {
    public int Id { get; set; }
    public string UserName { get; set; }
    public string StoreName { get; set; }
    public string PizzaName { get; set; }
    public int CrustType { get; set; }
    public int SizeType { get; set; }
    public DateTime? OrderTime { get; set; }

    public virtual CrustInfo CrustTypeNavigation { get; set; }
    public virtual SizeInfo SizeTypeNavigation { get; set; }
  }

}