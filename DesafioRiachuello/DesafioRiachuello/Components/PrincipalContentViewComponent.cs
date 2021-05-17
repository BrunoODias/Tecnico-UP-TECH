using Microsoft.AspNetCore.Mvc;
using ModelsServicesInterfaces;
using System.Collections.Generic;

namespace DesafioRiachuello.Components
{
    public class PrincipalContentViewComponent: ViewComponent
    {
        private GoogleAPIConnection _GoogleAPIConnection;
        public PrincipalContentViewComponent(GoogleAPIConnection googleAPIConnection)
        {
            _GoogleAPIConnection = googleAPIConnection;
        }
        public IViewComponentResult Invoke(List<ListBook> model = null) {
            if (model == null || model.Count < 1)
                model = GetDefaultModel();
            return View("/Views/Home/Components/PrincipalContent/PrincipalContent.cshtml", model);
        }

        private List<ListBook> GetDefaultModel() =>
            Models.Utils.getListListBook(_GoogleAPIConnection.GetNewest()); 
    }
}
