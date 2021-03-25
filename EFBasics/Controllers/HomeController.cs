using EFBasics.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EFBasics.Controllers
{
    public class HomeController : Controller
    {
        private readonly PetsContext _db;

        public HomeController(PetsContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var data = from owner in _db.Owners.Include(o => o.Pets)
                       where owner.Pets.Average(p => p.Age) > 4
                       select owner;

            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
