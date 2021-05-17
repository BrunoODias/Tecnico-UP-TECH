using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using ModelsServicesInterfaces;
using DesafioRiachuello.Interfaces;
using System.Security.Claims;
using System;

namespace DesafioRiachuello.Components
{
    public class LeftMenuViewComponent:ViewComponent
    {
        private IUserDal _userDal { get; set; }
        public LeftMenuViewComponent(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IViewComponentResult Invoke(List<ListBook> favorites = null) {
            if (favorites == null)
                favorites = GetDefaultModel();
            return View("/Views/Home/Components/LeftMenu/LeftMenu.cshtml", favorites);
        }
        private List<ListBook> GetDefaultModel()
        {
            var claims = UserClaimsPrincipal.Claims;
            Claim claim = null;
            foreach (var current in claims)
                if (current.Type == ClaimTypes.NameIdentifier)
                    claim = current;

            string _idUser = claim.Value;
            int idUser = Convert.ToInt32(_idUser);
            var books = _userDal.getFavorites(idUser);
            return DesafioRiachuello.Models.Utils.getListListBook(books);
        }
    }
}
