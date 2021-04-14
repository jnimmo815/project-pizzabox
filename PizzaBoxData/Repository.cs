using System.Collections.Generic;
using PizzaBoxLib;
using PizzaBoxLib.Models;
using System.Linq;

namespace PizzaBoxData
{
  public class Repository : IRepository
  {
    private readonly Entities.HeroContext context;
    IMapper mapper = new Mapper();
    public Repository(Entities.HeroContext context)
    {
      this.context = context;
    }
    public void AddOrderInfo3(OrderInfo3 orderInfo3)
    {
      context.Add(mapper.Map(orderInfo3));
      context.SaveChanges();
    }
    public List<OrderInfo3> GetAllOrderInfo3s()
    {
      var orderInfo3 = context.OrderInfo3s;
      return orderInfo3.Select(mapper.Map).ToList();
    }

    public void Delete(decimal id)
    {
      //  This meathod needs to be replace!
      context.Remove(id);
      context.SaveChanges();
    }


    // public SuperHero GetSuperHeroByName(string name)
    // {
    //   var superHero = context.SuperHeroes.Where(x => x.Alias == name).FirstOrDefault();
    //   return mapper.Map(superHero);
    // }
    public List<CrustInfo> GetAllCrustInfos()
    {
      var crustInfo = context.CrustInfos;
      return crustInfo.Select(mapper.Map).ToList();
    }
    public List<SizeInfo> GetAllSizeInfos()
    {
      var sizeInfo = context.SizeInfos;
      return sizeInfo.Select(mapper.Map).ToList();
    }
    public List<MyOrder> GetAllMyOrders()
    {
      var myOrder = context.MyOrders;
      return myOrder.Select(mapper.Map).ToList();
    }
    // public List<MyOrder> GetMyOrdersByUserName(string name)
    // {
    //   List<MyOrder> myOrders = context.MyOrders.
    //   return mapper.Map(myOrders);
    // }

  }
}