using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplicationVerstaTest.Models;

namespace WebApplicationVerstaTest.Controllers
{
    public class HomeController : Controller
    {
        OrderContext db;
        public HomeController(OrderContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await db.Orders.ToListAsync());
        }

        public IActionResult Create()
        {
            ViewBag.Action = "create";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Order order)
        {
            db.Orders.Add(order);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Watch(int? id)
        {
            ViewBag.Action = "watch";
            var order = db.Orders.Find(id.HasValue ? id.Value : 0);
            return View(order);
        }

        [HttpPost]
        public IActionResult Watch()
        {
            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
