using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syed_Rumail.Models;
using Microsoft.AspNetCore.Mvc;

namespace Syed_Rumail.Controllers
{
    public class HomeController : Controller
    {     
          
            public IActionResult Index()
            {
                return View("Home");
            }
      

        }
    }