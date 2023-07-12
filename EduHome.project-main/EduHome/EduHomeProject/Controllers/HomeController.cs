using EduHome.Core.Entities;
using EduHome.DataAccess.Contexts;
using EduHomeProject.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHomeProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new ()
            {
                Sliders=await _context.Slider.ToListAsync(),
                Blogs = await _context.Blogs.ToListAsync(),
            };
            return View(homeVM);
        }
    }
}
