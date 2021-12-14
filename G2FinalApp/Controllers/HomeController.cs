using G2FinalApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G2FinalApp.Controllers
{
    public class HomeController : Controller
    {
        public AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ViewBag.blogs = new SelectList(_db.Blogs);
            ViewBag.clients = new SelectList(_db.Clients);
            return View(_db.Products.ToList());
        }

    }
}
