using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
  /// <summary>
  /// 
  /// </summary>
  public class PizzaTests
  {
    /// <summary>
    /// 
    /// </summary>
    [Fact]
    public void Test_PizzaCrust()
    {
      // arrange
      var sut = new VeganPizza();

      // act
      var actual = sut.Crust;

      // assert
      Assert.Null(actual);
    }
    [Fact]
    public void Test_Vegan_Add_Size()
    {
      var sut = new VeganPizza();

      var actual = sut.Size;

      Assert.Null(actual);
    }

    [Fact]
    public void Test_PizzaName()
    {
      var sut = new MeatPizza();

      var actual = sut.Name;

      Assert.True(actual == "Meat Pizza");
    }
  }
}
