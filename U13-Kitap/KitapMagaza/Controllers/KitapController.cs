using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using KitapMagaza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace KitapMagaza.Controllers
{    
    public class KitapController : Controller
    {  
        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }  

        [HttpPost]
        public IActionResult Ekle(KitapModel kitapmodel)
        {
            return Content(kitapmodel.Id+" "+kitapmodel.KitapAd+" "+kitapmodel.SayfaSayisi);
        }   
    }
}