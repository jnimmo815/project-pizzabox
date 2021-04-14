using PizzaBoxData;
using PizzaBoxLib;
using Microsoft.EntityFrameworkCore;

namespace PizzaBox.Client
{
  public static class Dependencies
  {
    public static IRepository CreateRepository()
    {
      var optionsBuilder = new DbContextOptionsBuilder<PizzaBoxData.Entities.HeroContext>();
      optionsBuilder.UseSqlServer("Server=tcp:revature-training-james.database.windows.net,1433;Initial Catalog=Hero;Persist Security Info=False;User ID=james.nimmo;Password=Fligh=137;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
      var dbContext = new PizzaBoxData.Entities.HeroContext(optionsBuilder.Options);
      return new Repository(dbContext);
    }
  }
}