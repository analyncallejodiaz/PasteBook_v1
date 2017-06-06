using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasteBookDataAccess
{
    public interface IRepository :IDisposable
    {
        bool AddEntry<T>(T record) where T : class;
        bool EditEntry<T>(T record) where T : class;
        bool DeleteEntry<T>(T record) where T : class;
        T RetrieveRecord<T>(Func<T, bool> condition) where T : class;
        List<T> RetrieveListOfRecord<T>(Func<T, bool> condition) where T : class;
        bool CheckIfRecordExist<T>(Func<T, bool> condition) where T : class;
       
    }
}
