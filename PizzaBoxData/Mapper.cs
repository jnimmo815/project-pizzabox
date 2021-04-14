namespace PizzaBoxData
{
  public class Mapper : IMapper
  {

    public PizzaBoxLib.Models.CrustInfo Map(PizzaBoxData.Entities.CrustInfo crustInfo)
    {
      return new PizzaBoxLib.Models.CrustInfo
      {
        CrustId = crustInfo.CrustId,
        CrustName = crustInfo.CrustName,
        CrustPrice = crustInfo.CrustPrice
      };
    }
    public PizzaBoxData.Entities.CrustInfo Map(PizzaBoxLib.Models.CrustInfo crustInfo)
    {
      return new PizzaBoxData.Entities.CrustInfo
      {
        CrustId = crustInfo.CrustId,
        CrustName = crustInfo.CrustName,
        CrustPrice = crustInfo.CrustPrice
      };
    }
    public PizzaBoxLib.Models.SizeInfo Map(PizzaBoxData.Entities.SizeInfo sizeInfo)
    {
      return new PizzaBoxLib.Models.SizeInfo
      {
        SizeId = sizeInfo.SizeId,
        SizeName = sizeInfo.SizeName,
        SizePrice = sizeInfo.SizePrice
      };
    }
    public PizzaBoxData.Entities.SizeInfo Map(PizzaBoxLib.Models.SizeInfo sizeInfo)
    {
      return new PizzaBoxData.Entities.SizeInfo
      {
        SizeId = sizeInfo.SizeId,
        SizeName = sizeInfo.SizeName,
        SizePrice = sizeInfo.SizePrice
      };
    }
    public PizzaBoxLib.Models.OrderInfo3 Map(PizzaBoxData.Entities.OrderInfo3 orderInfo3)
    {
      return new PizzaBoxLib.Models.OrderInfo3
      {
        Id = orderInfo3.Id,
        UserName = orderInfo3.UserName,
        StoreName = orderInfo3.StoreName,
        PizzaName = orderInfo3.PizzaName,
        CrustType = orderInfo3.CrustType,
        SizeType = orderInfo3.SizeType,
        OrderTime = System.DateTime.Now
      };
    }
    public PizzaBoxData.Entities.OrderInfo3 Map(PizzaBoxLib.Models.OrderInfo3 orderInfo3)
    {
      return new PizzaBoxData.Entities.OrderInfo3
      {
        Id = orderInfo3.Id,
        UserName = orderInfo3.UserName,
        StoreName = orderInfo3.StoreName,
        PizzaName = orderInfo3.PizzaName,
        CrustType = orderInfo3.CrustType,
        SizeType = orderInfo3.SizeType,
        OrderTime = System.DateTime.Now
      };
    }
    public PizzaBoxLib.Models.MyOrder Map(PizzaBoxData.Entities.MyOrder myOrder)
    {
      return new PizzaBoxLib.Models.MyOrder
      {
        Id = myOrder.Id,
        UserName = myOrder.UserName,
        StoreName = myOrder.StoreName,
        PizzaName = myOrder.PizzaName,
        CrustName = myOrder.CrustName,
        SizeName = myOrder.SizeName,
        CrustPrice = myOrder.CrustPrice,
        SizePrice = myOrder.SizePrice,
        OrderTime = myOrder.OrderTime
      };
    }
    public PizzaBoxData.Entities.MyOrder Map(PizzaBoxLib.Models.MyOrder myOrder)
    {
      return new PizzaBoxData.Entities.MyOrder
      {
        Id = myOrder.Id,
        UserName = myOrder.UserName,
        StoreName = myOrder.StoreName,
        PizzaName = myOrder.PizzaName,
        CrustName = myOrder.CrustName,
        SizeName = myOrder.SizeName,
        CrustPrice = myOrder.CrustPrice,
        SizePrice = myOrder.SizePrice,
        OrderTime = myOrder.OrderTime
      };
    }
  }
}