using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DesafioRiachuello.Controllers
{
    public class WebController: Controller
    {
        protected int getUserId()
        {
            var claims = base.HttpContext.User.Claims;
            Claim claim = null;
            foreach (var current in claims)
                if (current.Type == ClaimTypes.NameIdentifier)
                    claim = current;

            string _idUser = claim.Value;
            return Convert.ToInt32(_idUser);
        }

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
