using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasteBookEF;
using System.Data.Entity;

namespace PasteBookDataAccess
{
    public class Repository <T> : IRepository <T> where T : class

    {
        public virtual bool AddEntry(T record)
        {
            try
            {
                using (var context = new PasteBookEntities())
                {
                    context.Entry(record).State = EntityState.Added;
                    var result = context.SaveChanges();
                    return result != 0 ? true : false;
                     
                }
            }catch(Exception ex)
            {
                return false;
            }
        }

        public virtual bool EditEntry(T record)
        {

            try
            {
                using (var context = new PasteBookEntities())
                {
                    context.Entry(record).State = EntityState.Modified;
                    var result = context.SaveChanges();
                    return result != 0 ? true : false;
                }
            }catch(Exception ex)
            {
                return false;
            }
        }

        public virtual bool DeleteEntry(T record)
        {
            try
            {
                using (var context = new PasteBookEntities())
                {
                    context.Entry(record).State = EntityState.Deleted;
                    var result = context.SaveChanges();
                    return result != 0 ? true : false;
                }
            }catch(Exception ex)
            {
                return false;
            }
        }

        public virtual T RetrieveRecord(Func<T, bool> condition)
        {
            try
            {
                using (var context = new PasteBookEntities())
                {
                    IQueryable<T> query = context.Set<T>();
                    T ret = query.Where(condition).SingleOrDefault();
                    return ret;

                }
            }catch(Exception ex)
            {
                return null;
            }
        }

        public virtual List<T> RetrieveListOfRecord(Func<T, bool> condition) 
        {
            List<T> listOfRecords = new List<T>();
            try
            {
                using (var context = new PasteBookEntities())
                {
                    IQueryable<T> query = context.Set<T>();
                    listOfRecords = query.Where(condition).ToList();
                    return listOfRecords;
                }
            }catch(Exception ex)
            {
                return null;
            }
        }

        public virtual bool CheckIfRecordExist(Func<T, bool> condition)
        {
            try
            {
                using (var context = new PasteBookEntities())
                {
                    IQueryable<T> query = context.Set<T>();
                    var ret = query.Where(condition).Any();
                    return ret;
                }
            }catch(Exception ex)
            {
                return false;
            }
        }

     

    }
}
