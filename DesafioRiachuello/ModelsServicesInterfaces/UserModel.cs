using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioRiachuello.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }

        public bool IsValidToInsert(out string retorno)
        {
            StringBuilder sb = new StringBuilder();
            if (string.IsNullOrWhiteSpace(Name) || Name.Length < 6)
                sb.AppendLine(" • O nome do usuário deve haver pelo menos 6 caracteres" + Environment.NewLine);

            if (string.IsNullOrWhiteSpace(Password) || Password.Length < 8)
                sb.AppendLine(" • A senha do usuário deve haver pelo menos 8 caracteres" + Environment.NewLine);

            if (string.IsNullOrWhiteSpace(Email) || Email.Contains("@") == false)
                sb.AppendLine(" • O email informado não é válido" + Environment.NewLine);

            if (string.IsNullOrWhiteSpace(UserName) || UserName.Length < 6)
                sb.AppendLine(" • O nome de usuário de ve haver pelo menos 6 caracteres" + Environment.NewLine);

            if (DateTime.MinValue == BirthDate || DateTime.MaxValue == BirthDate)
                sb.AppendLine(" • A data informada não é válida" + Environment.NewLine);

            retorno = sb.ToString();
            return string.IsNullOrWhiteSpace(retorno);
        }
    }
}
