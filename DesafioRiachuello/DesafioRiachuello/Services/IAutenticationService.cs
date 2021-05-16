using DesafioRiachuello.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace DesafioRiachuello.Interfaces
{
    public interface IAutenticationService
    {
        public Task<bool> LoginBrowser(UserModel user, HttpContext context);
    }
}
