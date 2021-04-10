using System.Xml.Serialization;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
  /// <summary>
  /// Represents the Store Abstract Class
  /// </summary>
  [XmlInclude(typeof(ChicagoStore))]
  [XmlInclude(typeof(NewYorkStore))]
  public abstract class AStore
  {
    public string Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    protected AStore()
    {

    }

    public override string ToString()
    {
      return $"{Name}";
    }

  }

}
