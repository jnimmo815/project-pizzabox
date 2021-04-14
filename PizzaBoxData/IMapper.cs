using PizzaBoxLib.Models;

namespace PizzaBoxData
{
  public interface IMapper
  {
    PizzaBoxLib.Models.CrustInfo Map(PizzaBoxData.Entities.CrustInfo crustInfo);
    PizzaBoxData.Entities.CrustInfo Map(PizzaBoxLib.Models.CrustInfo crustInfo);
    PizzaBoxLib.Models.SizeInfo Map(PizzaBoxData.Entities.SizeInfo sizeInfo);
    PizzaBoxData.Entities.SizeInfo Map(PizzaBoxLib.Models.SizeInfo sizeInfo);
    PizzaBoxLib.Models.OrderInfo3 Map(PizzaBoxData.Entities.OrderInfo3 orderInfo3);
    PizzaBoxData.Entities.OrderInfo3 Map(PizzaBoxLib.Models.OrderInfo3 orderInfo3);
    PizzaBoxLib.Models.MyOrder Map(PizzaBoxData.Entities.MyOrder myOrder);
    PizzaBoxData.Entities.MyOrder Map(PizzaBoxLib.Models.MyOrder myOrder);

  }
}