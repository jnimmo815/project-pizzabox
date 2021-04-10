using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class CustomPizza : APizza
  {
    public CustomPizza()
    {
      Name = "Custom Pizza";
    }
    public override void AddToppings()
    {
      Toppings.Add(new Topping());
    }
  }
}