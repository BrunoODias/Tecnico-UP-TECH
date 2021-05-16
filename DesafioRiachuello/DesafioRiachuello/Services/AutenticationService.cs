using DesafioRiachuello.Interfaces;
using DesafioRiachuello.Models;
using Microsoft.AspNetCore.Authentication;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DesafioRiachuello.Services
{
    public class AutenticationService : IAutenticationService
    {
        public async Task<bool> LoginBrowser(UserModel user, Microsoft.AspNetCore.Http.HttpContext context)
        {
            try
            {
                ClaimsPrincipal principal = new ClaimsPrincipal();
                ClaimsIdentity claimIdentity = new ClaimsIdentity("AuthorizationCookie");
                Claim claimIdUser = new Claim(ClaimTypes.NameIdentifier, user.Id.ToString());
                Claim claimUserName = new Claim(ClaimTypes.Name, user.Name);
                claimIdentity.AddClaim(claimIdUser);
                claimIdentity.AddClaim(claimUserName);
                principal.AddIdentity(claimIdentity);
                await context.SignInAsync(principal);
                return true;
            }
            catch (Exception) {
                return false;
            }
        }
    }
}
