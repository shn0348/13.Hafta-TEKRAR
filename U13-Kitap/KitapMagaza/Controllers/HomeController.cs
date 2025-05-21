using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using KitapMagaza.Models;

namespace KitapMagaza.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    
}
