using Microsoft.AspNetCore.Mvc;
using SphinxRiddle.Models;

namespace SphinxRiddle.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Home() { return View(); }

    [Route("/riddlequestion")]
    public ActionResult RiddleQuestion() { return View(); }
    // string answer1 = "memory";

    // [Route("/riddleanswer")]
    // public ActionResult RiddleAnswer()
    // {
    //   Riddle userRiddle = new Riddle();
    //   Riddle.Input = userInput;
    //   return View(userRiddle);
    // }
  }
}