using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/index")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/game/new")]
    public ActionResult Create(string userInputWord, string userInputSentence)
    {
      RepeatCounter newUserInput = new RepeatCounter(userInputWord, userInputSentence);
      return View(RepeatCounter.GetCurrentGame());
    }


  }
}
