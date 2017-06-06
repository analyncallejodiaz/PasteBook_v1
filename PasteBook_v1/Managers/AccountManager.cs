using PasteBookEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PasteBookBusinessLogic;
using PasteBookBusinessLogic.BusinessLogics;

namespace PasteBook_v1
{
    public class AccountManager
    {
        public void AddUser(USER newUser)
        {
            AccountMethods.AddUser(newUser);
        }

        public bool LoginUser(string userName, string password)
        {
            return AccountMethods.LoginUser(userName,password);
        }
    }
}