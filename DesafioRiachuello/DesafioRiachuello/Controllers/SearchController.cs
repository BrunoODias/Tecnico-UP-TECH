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
    [Authorize]
    public class SearchController : Controller
    {
        private GoogleAPIConnection _googleAPIConnection { get; set; }
        public SearchController(GoogleAPIConnection googleAPIConnection)
        {
            _googleAPIConnection = googleAPIConnection;
        }

        [Route("/Search/GetBookName/{term}/{page=0}")]
        public IActionResult GetBookName(string term,string page)
        {
            int res = 0;
            if (string.IsNullOrWhiteSpace(page) || int.TryParse(page, out res) == false)
            {
                page = "0";
            }
            if (res < 0)
                page = "0";

            int totalPages = 0;
            List<Book> books = _googleAPIConnection.GetByTerm(term, page, out totalPages);
            List<ListBook> toDisplay = Utils.getListListBook(books);
            ViewData["BooksToDisplay"] = toDisplay;
            ViewData["CurrentPage"] = page;
            ViewData["TotalPages"] = totalPages;
            return View("/views/Home/Index.cshtml");
        }

        [Route("/Search/GetAuthorName/{term}/{page=0}")]
        public IActionResult GetAuthorName(string term, string page)
        {
            int res = 0;
            if (string.IsNullOrWhiteSpace(page) || int.TryParse(page, out res) == false) {
                page = "0";
            }
            if (res < 0)
                page = "0";
            int totalPages = 0;
            List<Book> books = _googleAPIConnection.GetByAuthor(term,page, out totalPages);
            List<ListBook> toDisplay = Utils.getListListBook(books);
            ViewData["BooksToDisplay"] = toDisplay;
            ViewData["CurrentPage"] = page;
            ViewData["TotalPages"] = totalPages;
            return View("/views/Home/Index.cshtml");
        }

        [Route("/Search/GetCategoryName/{term}/{page=0}")]
        public IActionResult GetCategoryName(string term, string page)
        {
            int res = 0;
            if (string.IsNullOrWhiteSpace(page) || int.TryParse(page, out res) == false)
            {
                page = "0";
            }
            if (res < 0)
                page = "0";
            int totalPages = 0;
            List<Book> books = _googleAPIConnection.GetByCategory(term,page, out totalPages);
            List<ListBook> toDisplay = Utils.getListListBook(books);
            ViewData["BooksToDisplay"] = toDisplay;
            ViewData["CurrentPage"] = page;
            ViewData["TotalPages"] = totalPages;
            return View("/views/Home/Index.cshtml");
        }
    }
}
