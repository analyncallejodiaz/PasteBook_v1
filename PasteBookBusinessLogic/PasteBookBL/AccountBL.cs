using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasteBookDataAccess;
using PasteBookEF;

namespace PasteBookBusinessLogic.PasteBookBL
{
    public class AccountBL
    {
        IRepository repo;

        public USER getUser(string userName)
        {
            return repo.RetrieveRecord<USER>(x=>x.USER_NAME== userName);
        }

    }
}
