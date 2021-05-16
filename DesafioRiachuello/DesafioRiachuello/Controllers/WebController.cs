using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioRiachuello.Controllers
{
    public class WebController:Controller
    {
        public IActionResult ReturnMsgToFront(string view, string msg) {
            ViewBag.Msg = msg;
            return View(view);
        }
        public IActionResult ReturnErrorToFront(string view, string Erro)
        {
            ViewBag.Erro = Erro;
            return View(view);
        }
    }
}
