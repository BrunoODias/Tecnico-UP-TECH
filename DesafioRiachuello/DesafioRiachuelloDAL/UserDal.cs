using CriptoAndHashService;
using DesafioRiachuello.Interfaces;
using DesafioRiachuello.Models;
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
    }
}