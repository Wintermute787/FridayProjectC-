using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
    public class WordController : Controller

    {
        [HttpGet("/word")]
        public ActionResult Index()
        {
            List<Phrase> AllItems = Phrase.GetAll();
            return View(AllItems);
        }

        [HttpGet("/word/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/word")]
        public ActionResult Create(string sentence, string checkword)
        {
            Phrase phrase = new Phrase(sentence, checkword);
            return RedirectToAction("index");
        }
    }
}