using Microsoft.AspNetCore.Mvc;
using MonopolyWebApp.Models;

namespace MonopolyWebApp.Controllers
{
    public class BoardController : Controller
    {
        public ActionResult BoardIndex()
        {

            return View("Board", new Board());
        }
    }
}
