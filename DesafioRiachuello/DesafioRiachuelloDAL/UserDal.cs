using CriptoAndHashService;
using DesafioRiachuello.Interfaces;
using DesafioRiachuello.Models;
using ModelsServicesInterfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DesafioRiachuelloDAL
{
    public class UserDal : BaseDal, IUserDal
    {
        public UserModel GetUser(UserLoginModel loginModel)
        {
            if (string.IsNullOrWhiteSpace(loginModel.UserName) || string.IsNullOrWhiteSpace(loginModel.Password))
            {
                throw new CustomMessageException("Usuário e/ou senha inválidos");
            }

            string comando = "SELECT * FROM Usuarios WHERE UserName = @UserName AND Password = @Password";
            var res = ExecuteReader(comando, new List<SqlParameter> {
                new SqlParameter("UserName", loginModel.UserName),
                new SqlParameter("Password", HashService.GetHash(loginModel.Password)),
            });

            if (res == null) return null;

            foreach (var current in res) {
                var retorno = new UserModel();
                retorno.Id = Convert.ToInt32(current.Id);
                retorno.BirthDate = Convert.ToDateTime(current.BirthDate);
                retorno.Email = current.Email;
                retorno.Name = current.Name;
                retorno.UserName = current.UserName;
                retorno.Password = null;
                return retorno;
            }
            return null;
        }
        public bool IsValidLogin(UserLoginModel loginModel, out UserModel user)
        {
            var ret = GetUser(loginModel);
            user = ret;
            if (ret != null)
                return true;
            return false;
        }
        private bool ExistsUserWhithEmailOrUserName(UserModel user) =>
            ExecuteScalar("SELECT * FROM Usuarios WHERE UserName = @UserName OR Email = @Email",
                new List<SqlParameter>() {
                    new SqlParameter("UserName",user.UserName),
                    new SqlParameter("Email",user.Email)
                }) != null;
        public bool RegisterUser(UserModel userModel, out string erros)
        {
            if (userModel.IsValidToInsert(out erros) == false) {
                return false;
            }
            if (ExistsUserWhithEmailOrUserName(userModel)) {
                erros = " • Já existe um usuário com este UserName ou Email. ";
                return false;
            }

            try
            {
                erros = "";
                ExecuteNonQuery("INSERT INTO Usuarios(Name,Email,UserName,Password,BirthDate)" +
                    "values" +
                    "(@Name,@Email,@UserName,@Password,@BirthDate)",
                    new List<SqlParameter>() {
                    new SqlParameter("Name",userModel.Name),
                    new SqlParameter("Email",userModel.Email),
                    new SqlParameter("UserName",userModel.UserName),
                    new SqlParameter("Password",HashService.GetHash(userModel.Password)),
                    new SqlParameter("BirthDate",userModel.BirthDate),
                    });
                return true;
            }
            catch (Exception) {
                erros = "Houve um erro ao salvar o usuário";
                return false;
            }
        }

        public List<Book> getFavorites(int IdUser)
        {
            string comando = "SELECT Code,Name,Gender FROM Favorites WHERE IdUser = @IdUser;";
            var res = ExecuteReader(comando, new SqlParameter("IdUser",IdUser));
            if (res == null)
                return null;

            var books = new List<Book>();
            foreach (var current in res) {
                books.Add(
                    new Book()
                    {
                        Code = current.Code,
                        Name = current.Name,
                        Gender = current.Gender,
                    }
                );
            }
            
            return books;
        }
        public bool addFavorite(int IdUser, Book book, out string erros)
        {
            if (IdUser == 0 || book == null || string.IsNullOrWhiteSpace(book.Code) || string.IsNullOrWhiteSpace(book.Gender))
            {
                erros = "Parâmetros inválidos";
                return false;
            }

            string comando = "INSERT INTO Favorites (IdUser,Code,Name,Gender,GoogleBooksURL)VALUES(@IdUser, @Code, @Name, @Gender,@GoogleBooksURL)";
            base.ExecuteNonQuery(comando, new List<SqlParameter>() {
                new SqlParameter("IdUser",IdUser),
                new SqlParameter("Code",book.Code),
                new SqlParameter("Name",book.Name),
                new SqlParameter("Gender",book.Gender),
                new SqlParameter("GoogleBooksURL",book.GoogleBooksURL)
            });
            erros = "";
            return true;
        }
        public bool removeFavorite(int IdUser, Book book, out string erros)
        {
            if (IdUser == 0 || book == null || book.Code == null)
            {
                erros = "Parâmetros inválidos";
                return false;
            }

            string comando = "DELETE FROM Favorites Where IdUser = @IdUser AND Code = @Code AND Name = @Name";
            base.ExecuteNonQuery(comando, new List<SqlParameter>() { 
                new SqlParameter("IdUser",IdUser),
                new SqlParameter("Code",book.Code),
                new SqlParameter("Name",book.Name)
            });
            erros = "";
            return true;
        }

        public void setFavorites(List<Book> books,int idUser)
        {
            try
            {
                foreach (var current in books)
                    current.isFavorite = false;
                string comando = "SELECT Code FROM Favorites WHERE IdUser = @IdUser";
                var res = base.ExecuteReader(comando, new SqlParameter("IdUser", idUser));
                if (res != null)
                {
                    foreach (var current in res)
                    {
                        var book = books.Find(x => x.Code == Convert.ToString(current.Code));
                        if(book != null)
                            book.isFavorite = true;
                    }
                };
            }
            catch (Exception e)
            {

            }
        }

        public void setFavorite(Book book,int idUser)
        {
            try
            {
                book.isFavorite = false;
                var res = base.ExecuteScalar("SELECT Code FROM Favorites WHERE IdUser = @IdUser AND Code = @Code ", new List<SqlParameter>(){new SqlParameter("Code", book.Code),new SqlParameter("IdUser", idUser)});
                if (res != null)
                    book.isFavorite = true;
            }
            catch (Exception e)
            {

            }
        }
    }
}