using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using proje_4.Data;


namespace proje_4.Controllers
{
    public class ShopController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ShopController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var result = _context.Products.ToList();
            return View(result);
        }
    }
}

