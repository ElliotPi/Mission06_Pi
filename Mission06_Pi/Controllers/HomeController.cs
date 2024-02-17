using Microsoft.AspNetCore.Mvc;
using Mission06_Pi.Models;
using System.Diagnostics;

namespace Mission06_Pi.Controllers
{
    public class HomeController : Controller
    {
        private MovieCollectionContext _context;

        public HomeController(MovieCollectionContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieCollection()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieCollection(MovieCollectionModel response)
        {
            _context.MovieCollections.Add(response);
            _context.SaveChanges();

            return View("Confirmation", response);
        }
    }
}
