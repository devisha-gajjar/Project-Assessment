using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

[Authorize(Roles = "Admin")]
public class AdminContrtoller : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
