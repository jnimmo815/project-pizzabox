using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class HawaiianPizza : APizza
  {
    public HawaiianPizza()
    {
      Name = "Hawaiian Pizza";
    }
    public override void AddToppings()
    {
      Toppings.Add(new Topping());
    }
  }
}