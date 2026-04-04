using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FoodPandaClone.Data;

namespace FoodPandaClone.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public HomeController(ApplicationDbContext db) { _db = db; }

        public async Task<IActionResult> Index(string search)
        {
            var products = _db.Products.Include(p => p.Category).AsQueryable();

            // সার্চ লজিক
            if (!string.IsNullOrEmpty(search))
            {
                products = products.Where(p => p.Name.Contains(search) || p.Category.Name.Contains(search));
            }

            return View(await products.ToListAsync());
        }
    }
}