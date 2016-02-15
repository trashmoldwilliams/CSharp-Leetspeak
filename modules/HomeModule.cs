using Nancy;
using LeetSpeakNS.Objects;
using System.Collections.Generic;

namespace LeetSpeakNS
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["header.cshtml"];
      };
    }
  }
}
