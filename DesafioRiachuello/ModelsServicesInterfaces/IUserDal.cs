using DesafioRiachuello.Models;
using ModelsServicesInterfaces;
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
        public List<Book> getFavorites(int IdUser);
        public bool addFavorite(int IdUser, Book book, out string erros);
        public bool removeFavorite(int IdUser, Book book,out string erros);
        public void setFavorite(Book book, int idUser);
        public void setFavorites(List<Book> books, int idUser);
    }
}
