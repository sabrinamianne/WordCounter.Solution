using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      RepeatCounter newGame = new RepeatCounter("word", "sentence");

      return View(newGame);
    }

    [HttpGet("/gamewc/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/gamewc")]
    public ActionResult Create (string word, string sentence)
    {
      RepeatCounter newGame = new RepeatCounter(word, sentence);
      return View("GameWC", newGame);
    }
  }
}
