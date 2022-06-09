using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nest2.DAL;
using Nest2.ViewModels;
using Nest2.ViewModels.HomeVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nest2.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVm homeVM = new HomeVm()
            {
                Sliders = await _context.Sliders.ToListAsync(),
                Categories = await _context.Categories.ToListAsync(),
                Products = await _context.Products.Include(p=>p.ProductImages).Include(p => p.Category).Take(10).ToListAsync()
            };
            return View(homeVM);
        }
    }
}
