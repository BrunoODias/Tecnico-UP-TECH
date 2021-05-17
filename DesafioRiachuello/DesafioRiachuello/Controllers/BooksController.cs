using DesafioRiachuello.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ModelsServicesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioRiachuello.Controllers
{
    [Authorize]
    public class BooksController : WebController
    {
        private GoogleAPIConnection _googleAPIConnection;
        private IUserDal _userDal;
        public BooksController(GoogleAPIConnection googleAPIConnection, IUserDal userDal)
        {
            _googleAPIConnection = googleAPIConnection;
            _userDal = userDal;
        }

        [Route("/Books/Details/{code=\"\"}")]
        public IActionResult Details(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
                return ReturnErrorToFront("/Views/Home/Index.cshtml","Não foi possível identificar o livro");

            Book book = _googleAPIConnection.GetByCode(code);

            _userDal.setFavorite(book, getUserId());

            if(book == null)
                return ReturnErrorToFront("/Views/Home/Index.cshtml", "Não foi possível encontrar o livro");
            
            return View(book);
        }
    }
}