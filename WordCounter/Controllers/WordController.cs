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
        public ActionResult Create(string sentence, string checkedword)
        {
            Phrase newphrase = new Phrase(sentence, checkedword);
            return RedirectToAction("Index");
        }
    }
}