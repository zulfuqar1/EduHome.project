using AutoMapper;
using EduHome.Core.Entities;
using EduHome.DataAccess.Contexts;
using EduHomeProject.UI.Areas.EduHomeAdmin.ViewModels.BlogViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHomeProject.Areas.EduHomeAdmin.Controllers;
[Area("EduHomeAdmin")]
public class BlogController : Controller
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;
    public BlogController(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task < IActionResult> Index()
    {
        return View(await _context.Blogs.ToListAsync());
    }

    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    [AutoValidateAntiforgeryToken]
    public async Task<IActionResult> Create(BlogPostViewModel BlogPost)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        Blog Blog = _mapper.Map<Blog>(BlogPost);
        return Json(Blog); 
        await _context.Blogs.AddAsync(Blog);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int Id)
    {
        Blog? blogdb = await _context.Blogs.FindAsync(Id);
        if (blogdb == null)
        {
            return NotFound();
        }
        return View(blogdb);
    }
    [HttpPost]
    [ActionName("Delete")]
    [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> DeletePost(int Id)
        {
            Blog? blogdb = await _context.Blogs.FindAsync(Id);
            if (blogdb == null)
            {
                return RedirectToAction(nameof(Index));
            }
            _context.Blogs.Remove(blogdb);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
        }



    public async Task<IActionResult> Update(int Id)
    {
        Blog? blogdb = await _context.Blogs.FindAsync(Id);
        if (blogdb == null)
        {
            return NotFound();
        }
        return View(blogdb);
    }

}