using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasteBookBusinessLogic.Manager
{
   public class PasswordManager
    {
        HashGenerator hashGenerator = new HashGenerator();
        public string GetHashPassword(string password, out string salt)
        {
            salt = SaltGenerator.GetSaltString();
            string newPassword = password + salt;
            return hashGenerator.GetPasswordHash(newPassword);

        }

        public bool IsPasswordMatch(string password , string salt, string hash)
        {
            string newPassword = password + salt;
            var hashNew = hashGenerator.GetPasswordHash(newPassword);
            return hash == hashNew;
        }
    }
}
