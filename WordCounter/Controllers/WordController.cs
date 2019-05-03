using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
    public class WordController : Controller

    {
        [HttpGet("/word")]
        public ActionResult Index(Phrase newphrase)
        {
            
            return View(newphrase);
            
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
            string userPhrase = newphrase.GetPhrase().ToLower();
            string userWord = newphrase.GetWord().ToLower();
            int wordCount = newphrase.CheckRepeatedWord();
            return View("index",newphrase);
      
            
        }
    }
}