using Microsoft.AspNetCore.Mvc;
using First_MVC_APP.Models;

namespace First_MVC_APP.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            PlayerViewModel player = new PlayerViewModel() { Name = "Jakub", Surname = "Klik", Age = 21, Possition = "Sharp Shooter", Number = 1 };
            return View(player);
        }

        public IActionResult Create()
        {
            var nPlayer = new PlayerViewModel();
            return View(nPlayer);
        }

        public IActionResult CreatePlayer(PlayerViewModel newPlayer)
        {
            return View("Index");
        }
    }
}
