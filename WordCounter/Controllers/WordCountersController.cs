using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCountersController : Controller
  {
    [HttpGet("/wordcounters")]
    public ActionResult Index(string word, string sentence)
    {
      RepeatCounter newGame = new RepeatCounter(word, sentence);
      return View(newGame);
    }

    [HttpGet("/wordcounters/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/wordcounters")]
    public ActionResult Create (string word, string sentence)
    {

      RepeatCounter newGame = new RepeatCounter(word, sentence);
      return View("Index", newGame);
    }


  }
}
