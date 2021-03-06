using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

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

    [HttpGet("/wordcounters/{id}/list")]
    public ActionResult Show(int id)
    {
       RepeatCounter game = RepeatCounter.Find(id);
       List<RepeatCounter> newList = RepeatCounter.GetAll();
       return View(newList);
    }

    [HttpPost("/wordcounters/delete")]
      public ActionResult DeleteAll()
      {
        RepeatCounter.ClearAll();
        return View();
      }
  }
}
