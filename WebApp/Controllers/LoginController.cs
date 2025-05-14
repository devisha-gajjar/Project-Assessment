using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApp.Entities.ViewModels;
using WebApp.Entities.Model;

namespace WebApp.Controllers;

public class LoginController : Controller
{
    private readonly ILogger<LoginController> _logger;

    public LoginController(ILogger<LoginController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    #region Login
    [HttpPost]
    public IActionResult Index(LoginViewModel loginViewModel)
    {
        if (!ModelState.IsValid)
        {
            return View(loginViewModel);
        }

        return View();

        // var(bool, string) userAuthenticateViewModel = _login.AuthenticateUser(loginViewModel);

        // if (!userAuthenticateViewModel.IsValid)
        // {
        //     TempData["error"] = "Invalid Username or Password";
        //     return View(loginViewModel);
        // }

        // if (!userAuthenticateViewModel.IsActive)
        // {
        //     TempData["error"] = "Inactive User!!";
        //     return View(loginViewModel);
        // }

        // CookieOptions options = new CookieOptions()
        // {
        //     Domain = "localhost",                   // domain for the cookie
        //     Path = "/",                             // Cookie is available within the entire application
        //     Secure = false,                         // Ensure the cookie is only sent over HTTPS (set to false for local development)
        //     Expires = loginViewModel.RememberMe ? DateTime.Now.AddDays(30) : DateTime.Now.AddHours(24), //setiing the expiration based on remember me 
        //     HttpOnly = true,                        // Prevent client-side scripts from accessing the cookie
        //     IsEssential = true                      // Indicates the cookie is essential for the application to function
        // };
        // Response.Cookies.Append("Token", userAuthenticateViewModel.Token, options);

        // string role = new JwtSecurityTokenHandler().ReadJwtToken(userAuthenticateViewModel.Token)
        //                .Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value!;

        // if (userAuthenticateViewModel.IsFirstTimeLogin && role != "Chef")
        // {
        //     return RedirectToAction("ChangePassword", "custom");
        // }

        // TempData["success"] = "Login success";



        // return role switch
        // {
        //     "Admin" => RedirectToAction("index", "Dashboard"),
        //     "Account Manager" => RedirectToAction("index", "Dashboard"),
        //     "Chef" => RedirectToAction("KOT", "OrderAppKOT"),
        //     _ => RedirectToAction("index", "Login")
        // };
    }
    #endregion

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
