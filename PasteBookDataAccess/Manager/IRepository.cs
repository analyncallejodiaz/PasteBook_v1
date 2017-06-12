using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasteBookDataAccess
{
    public interface IRepository <T> where T : class
    {
        bool AddEntry(T record);
        bool EditEntry(T record);
        bool DeleteEntry(T record);
        T RetrieveRecord(Func<T, bool> condition);
        List<T> RetrieveListOfRecord(Func<T, bool> condition);
        bool CheckIfRecordExist(Func<T, bool> condition);
       
    }
}
