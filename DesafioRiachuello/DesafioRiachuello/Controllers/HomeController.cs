using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;

namespace DesafioRiachuello.Controllers
{
    [Authorize]
    public class HomeController : WebController
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RefreshLeftMenu()
        {
            return ViewComponent("LeftMenu");
        }
    }
}
