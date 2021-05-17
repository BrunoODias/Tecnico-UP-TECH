using DesafioRiachuello.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ModelsServicesInterfaces;
using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace DesafioRiachuello.Components
{
    public class PrincipalContentViewComponent: ViewComponent
    {
        private GoogleAPIConnection _GoogleAPIConnection;
        private IUserDal _userDal;
        public PrincipalContentViewComponent(GoogleAPIConnection googleAPIConnection, IUserDal userDal)
        {
            _GoogleAPIConnection = googleAPIConnection;
            _userDal = userDal;
        }
        public IViewComponentResult Invoke(List<ListBook> model = null) {
            if (model == null || model.Count < 1)
                model = GetDefaultModel();
            foreach (var currentList in model)
                _userDal.setFavorites(currentList.Books, GetUserId());

            return View("/Views/Home/Components/PrincipalContent/PrincipalContent.cshtml", model);
        }

        private List<ListBook> GetDefaultModel() =>
            Models.Utils.getListListBook(_GoogleAPIConnection.GetNewest());

        private int GetUserId() {
            var claims = UserClaimsPrincipal.Claims;
            Claim claim = null;
            foreach (var current in claims)
                if (current.Type == ClaimTypes.NameIdentifier)
                    claim = current;

            string _idUser = claim.Value;
            return  Convert.ToInt32(_idUser);
        }
    }
}
