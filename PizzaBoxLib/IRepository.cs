using System.Collections.Generic;

namespace PizzaBoxLib
{
  public interface IRepository
  {
    //void Add(Models.SuperHero superHero);

    void AddOrderInfo3(Models.OrderInfo3 orderInfo3);

    List<Models.OrderInfo3> GetAllOrderInfo3s();
    // List<Models.Order> GetAllOrders();
    void Delete(decimal id);

    List<Models.CrustInfo> GetAllCrustInfos();
    List<Models.SizeInfo> GetAllSizeInfos();
    List<Models.MyOrder> GetAllMyOrders();
    //List<Models.MyOrder> GetMyOrdersByUserName(string name);
  }
}