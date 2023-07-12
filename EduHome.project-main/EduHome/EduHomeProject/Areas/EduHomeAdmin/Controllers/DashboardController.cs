using Microsoft.AspNetCore.Mvc;

namespace EduHomeProject.Areas.EduHomeAdmin.Controllers;

[Area("EduHomeAdmin")]
public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
