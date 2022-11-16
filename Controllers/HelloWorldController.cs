using Microsoft.AspNetCore.Mvc;
using First_MVC_APP.Models;

namespace First_MVC_APP.Controllers
{
    public class HelloWorldController : Controller
    {
        // We are using simple tab to save and write new player, without using data base 
        private static List<PlayerViewModel> players = new List<PlayerViewModel>();

        public IActionResult Index()
        {
            return View(players);
        }

        public IActionResult Create()
        {
            var nPlayer = new PlayerViewModel();
            return View(nPlayer);
        }

        public IActionResult CreatePlayer(PlayerViewModel newPlayer)
        {
            //adding new player to the list
            players.Add(newPlayer);

            //return View("Index");

            //we are redirecting to index method, which create object from PlayerViewModel class
            return RedirectToAction(nameof(Index));
        }
    }
}
