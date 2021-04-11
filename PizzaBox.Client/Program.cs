using System;
using PizzaBoxData.Entities;
using System.Linq;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Client.Singletons;

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
      Console.WriteLine("Fetching Super Hero");
      var superHeroes = GetSuperHeroes();
      foreach (var superHero in superHeroes)
      {
        Console.WriteLine($"{superHero.Id} {superHero.RealName} {superHero.Alias}");
      }
      // Run();
    }

    static List<SuperHero> GetSuperHeroes()
    {
      HeroContext context = new HeroContext();
      var superHeroes = context.SuperHeroes.ToList();
      return superHeroes;
    }

    /// <summary>
    /// 
    /// </summary>
    private static void Run()
    {

      //var order = new Order();

      Console.WriteLine("Welcome to PizzaBox");
      DisplayStoreMenu();

      //order.Customer = new Customer();
      // order.Store = SelectStore();
      // order.Pizza = SelectPizza();

      // order.Save();
    }

    /// <summary>
    /// 
    /// </summary>
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
        DisplayOrder(pizza);
        return pizza;
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
        DisplayPizzaMenu();
        return _storeSingleton.Stores[result - 1];
      }

    }
  }
}