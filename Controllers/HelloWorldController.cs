using Microsoft.AspNetCore.Mvc;
using First_MVC_APP.Models;

namespace First_MVC_APP.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel doggo = new DogViewModel()
            {Name = "Majki", Age = 11 };
            return View(doggo);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
