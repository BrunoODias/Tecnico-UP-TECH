using Microsoft.AspNetCore.Mvc;

namespace DesafioRiachuello.Components
{
    public class GenerateDisplayBookViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(ModelsServicesInterfaces.Book book) {
            return View("/Views/Home/Components/GenerateDisplayBook/GenerateDisplayBook.cshtml", book);
        }
    }
}
