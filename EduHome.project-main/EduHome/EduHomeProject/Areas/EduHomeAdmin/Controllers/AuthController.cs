using Microsoft.AspNetCore.Mvc;

namespace EduHomeProject.UI.Areas.EduHomeAdmin.Controllers;

public class AuthController : Controller
{
    public IActionResult Register()
    {
        return View();
    }
}
