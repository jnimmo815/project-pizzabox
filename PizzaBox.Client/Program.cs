using System;
using PizzaBoxData.Entities;
using PizzaBoxLib;
using System.Linq;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Client.Singletons;
using System.Globalization;

namespace PizzaBox.Client
{
  /// <summary>
  /// 
  /// </summary>
  internal class Program
  {
    private static readonly StoreSingleton _storeSingleton = StoreSingleton.Instance;
    private static readonly PizzaSingleton _pizzaSingleton = PizzaSingleton.Instance;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
      // IRepository repository = Dependencies.CreateRepository();

      // Console.WriteLine("Fetching Crust Infomation:");
      // RunUI(repository);
      MainMenu();
    }

    /// <summary>
    /// 
    /// </summary>
    private static void MainMenu()
    {
      Console.WriteLine("Welcome to PizzaBox");
      int choice = 7;
      while (choice != 1)
      {
        Console.WriteLine("Please choice from the following options: ");
        Console.WriteLine("1. Quite!");
        Console.WriteLine("2. Use the App as a customer: ");
        Console.WriteLine("3. Use the App as a employee: ");
        try
        {
          choice = int.Parse(Console.ReadLine());
        }
        catch
        {
          Console.WriteLine("Your choice is invailid!");
          break;
        }

        switch (choice)
        {
          case 1:
            break;
          case 2:
            CustomerMenu();
            break;
          case 3:
            EmployeeMenu();
            break;
          default:
            Console.WriteLine("Your choice is invailid!");
            break;
        }
      };
    }
    private static void CustomerMenu()
    {
      int choice = 0;
      Console.WriteLine("Welcome to the Customer Portal!");
      while (choice != 1)
      {
        Console.WriteLine("1. Leave the Customer Portal!");
        Console.WriteLine("2. Make a pizza order: ");
        // Console.WriteLine("2. View a pizzar order: ");
        try
        {
          choice = int.Parse(Console.ReadLine());
        }
        catch
        {
          Console.WriteLine("Your choice is invailid!");
          break;
        }
        switch (choice)
        {
          case 1:
            MainMenu();
            break;
          case 2:
            MakePizzaOrder();
            break;
          default:
            Console.WriteLine("Your choice is invailid!");
            break;
        }

      }
    }
    private static void EmployeeMenu()
    {
      int choice = 0;
      Console.WriteLine("Welcome to the Employee Portal!");
      while (choice != 1)
      {
        Console.WriteLine("1. Leave the Employee Portal!");
        Console.WriteLine("2. View pizza orders: ");
        // Console.WriteLine("2. View a pizzar order: ");
        try
        {
          choice = int.Parse(Console.ReadLine());
        }
        catch
        {
          Console.WriteLine("Your choice is invailid!");
          break;
        }
        switch (choice)
        {
          case 1:
            MainMenu();
            break;
          case 2:
            IRepository repository = Dependencies.CreateRepository();
            Console.WriteLine("Fetching pizza orders: ");
            ViewOrders(repository);
            break;
          default:
            Console.WriteLine("Your choice is invailid!");
            break;
        }
      }
    }
    private static void MakePizzaOrder()
    {
      IRepository repository = Dependencies.CreateRepository();

      Console.WriteLine("Welcome to PizzaBox Oder Systme");
      //  Building a orderInfo3 object
      Console.WriteLine("Enter a username.");
      string _UserName = Console.ReadLine();

      Console.WriteLine("Choice a store.");
      DisplayStoreMenu();
      string _StoreName = SelectStore().Name;

      DisplayPizzaMenu();
      string _PizzaName = SelectPizza().Name;

      DisplayCrust(repository);
      int _CrustType = SelectCrust();

      DisplaySize(repository);
      int _SizeType = SelectSize();

      DateTime _OrderTime = DateTime.Now;
      //order.Store = SelectStore();
      //order.Pizza = SelectPizza();
      PizzaBoxLib.Models.OrderInfo3 orderInfo3 = new PizzaBoxLib.Models.OrderInfo3
      {
        UserName = _UserName,
        StoreName = _StoreName,
        PizzaName = _PizzaName,
        CrustType = _CrustType,
        SizeType = _SizeType,
        OrderTime = _OrderTime
      };
      // Console.WriteLine($"{orderInfo3.StoreName}");
      repository.AddOrderInfo3(orderInfo3);
      //order.Save();
    }

    public static void ViewOrders(IRepository repository)
    {
      decimal BasePrice = (decimal)9.99;
      var myOrders = repository.GetAllMyOrders();
      Console.WriteLine("Order Id User Name     Store Name      Pizza Name      Crust     Size          Price       Time");
      foreach (var myOrder in myOrders)
      {
        double Price = (double)(BasePrice + myOrder.CrustPrice + myOrder.SizePrice);
        Console.WriteLine($"{myOrder.Id}      {myOrder.UserName}      {myOrder.StoreName}    {myOrder.PizzaName}     {myOrder.CrustName}     {myOrder.SizeName}     {Price}    {myOrder.OrderTime}");
      }
    }

    /// <summary>
    /// 
    /// </summary>
    private static void DisplayCrust(IRepository repository)
    {
      Console.WriteLine("Please select a type of crust.");
      var crustInfos = repository.GetAllCrustInfos();
      foreach (var crustInfo in crustInfos)
      {
        Console.WriteLine($"{crustInfo.CrustId} {crustInfo.CrustName}");
      }
    }
    private static void DisplaySize(IRepository repository)
    {
      Console.WriteLine("Please select a pizza size.");
      var sizeInfos = repository.GetAllSizeInfos();
      foreach (var sizeInfo in sizeInfos)
      {
        Console.WriteLine($"{sizeInfo.SizeId} {sizeInfo.SizeName}");
      }
    }
    private static void DisplayOrder(APizza pizza)
    {
      Console.WriteLine($"Your order is: {pizza}");
    }

    /// <summary>
    /// 
    /// </summary>
    private static void DisplayPizzaMenu()
    {
      var index = 0;
      Console.WriteLine("Select a pizza.");
      foreach (var item in _pizzaSingleton.Pizzas)
      {
        Console.WriteLine($"{++index} - {item}");
      }
    }

    /// <summary>
    /// 
    /// </summary>
    private static void DisplayStoreMenu()
    {
      var index = 0;

      foreach (var item in _storeSingleton.Stores)
      {
        Console.WriteLine($"{++index} - {item}");
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>

    private static string GetStoreName()
    {
      string input;
      input = Console.ReadLine();
      return input;
    }
    private static APizza SelectPizza()
    {
      int result;
      var input = int.TryParse(Console.ReadLine(), out result);
      if (result < 1)
      {
        System.Console.WriteLine("Your choice is invailid!");
        return null;
      }
      else
      {
        var pizza = _pizzaSingleton.Pizzas[result - 1];
        //  DisplayOrder(pizza);
        return pizza;
      }

    }
    public static int SelectCrust()
    {
      int result;
      var input = int.TryParse(Console.ReadLine(), out result);
      if (result < 1)
      {
        System.Console.WriteLine("Your choice is invailid!");
        return 0;
      }
      else
      {
        return result;
      }
    }
    public static int SelectSize()
    {
      int result;
      var input = int.TryParse(Console.ReadLine(), out result);
      if (result < 1)
      {
        System.Console.WriteLine("Your choice is invailid!");
        return 0;
      }
      else
      {
        return result;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static AStore SelectStore()
    {
      int result;
      var input = int.TryParse(Console.ReadLine(), out result); // be careful (think execpetion/error handling)

      if (result < 1)
      {
        System.Console.WriteLine("Your choice is invailid!");
        return null;
      }
      else
      {
        //  DisplayPizzaMenu();
        return _storeSingleton.Stores[result - 1];
      }

    }
  }
}