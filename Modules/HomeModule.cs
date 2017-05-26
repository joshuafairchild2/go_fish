using Nancy;
using System.Collections.Generic;
using GoFish.Objects;

namespace GoFish
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        Player player1 = new Player("Tom");


        return View["test.cshtml", player1];
      };
    }
  }
}
