using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WEBTRUYEN.Models;

namespace WEBTRUYEN.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Admin Dashboard";
            return View();
        }
    }
}
