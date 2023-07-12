using EduHome.DataAccess.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHomeProject.Areas.EduHomeAdmin.Controllers;
[Area("EduHomeAdmin")]
public class SliderController : Controller
{
    private readonly AppDbContext _context;

    public SliderController(AppDbContext context)
    {
        _context = context;
    }

    public async Task< IActionResult >Index()
    {
        return View(await _context.Slider.ToListAsync());
    }
}
