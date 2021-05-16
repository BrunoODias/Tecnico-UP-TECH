using DesafioRiachuello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioRiachuello.Interfaces
{
    public interface IUserDal
    {
        public UserModel GetUser(UserLoginModel loginModel);
        public bool RegisterUser(UserModel userModel, out string erros);
        public bool IsValidLogin(UserLoginModel loginModel, out UserModel user);
    }
}
