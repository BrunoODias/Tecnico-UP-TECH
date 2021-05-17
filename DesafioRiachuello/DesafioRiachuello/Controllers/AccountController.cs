using DesafioRiachuello.Interfaces;
using DesafioRiachuello.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ModelsServicesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioRiachuello.Controllers
{
    [AllowAnonymous]
    public class AccountController : WebController
    {
        private IAutenticationService _autenticationService;
        private IUserDal _userDal;
        public AccountController(IAutenticationService autenticationService, IUserDal userDal)
        {
            _autenticationService = autenticationService;
            _userDal = userDal;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login([FromForm] UserLoginModel userLogin)
        {
            try
            {
                UserModel user = new UserModel();
                if (_userDal.IsValidLogin(userLogin, out user))
                {
                    if (await _autenticationService.LoginBrowser(user, HttpContext))
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                        return ReturnErrorToFront("Login", "Houve um erro ao tentar logar!");
                }
                else
                    return ReturnErrorToFront("Login", "Não existe um usuário com essas credenciais!");
            }
            catch (CustomMessageException custom)
            {
                return ReturnErrorToFront("Login", custom.Message);
            }
            catch (Exception) { 
                return ReturnErrorToFront("Login", "Houve um erro ao tentar logar!");
            }

        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register([FromForm] UserModel user)
        {
            string erros = "";
            if (_userDal.RegisterUser(user, out erros) == false) {
                return ReturnErrorToFront("Register", erros);
            }
                return ReturnMsgToFront("Register", "Usuário cadastrado com sucesso!");
        }


        public IActionResult AddFavorite(string model)
        {
            try
            {
                var book = Newtonsoft.Json.JsonConvert.DeserializeObject<Book>(model);
                string erros = "";
                _userDal.addFavorite(getUserId(), book, out erros);
                if (string.IsNullOrWhiteSpace(erros))
                {
                    return Ok("Adicionado aos favoritos com sucesso!");
                }
                else
                {
                    return BadRequest(erros);
                }
            }
            catch (Exception)
            {
                return BadRequest("Erro ao tentar adicionar aos favoritos");
            }

        }

        public IActionResult RemoveFavorite(string model) {
            try
            {
                var book = Newtonsoft.Json.JsonConvert.DeserializeObject<Book>(model);
                string erros = "";
                _userDal.removeFavorite(getUserId(), book, out erros);
                if (string.IsNullOrWhiteSpace(erros))
                {
                    return Ok("Removido dos favoritos com sucesso!");
                }
                else
                {
                    return BadRequest(erros);
                }
            }
            catch (Exception) { 
                return BadRequest("Erro ao tentar remover dos favoritos");
            }
        }
    }
}
