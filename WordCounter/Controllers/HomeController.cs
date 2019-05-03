using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordFinder.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}