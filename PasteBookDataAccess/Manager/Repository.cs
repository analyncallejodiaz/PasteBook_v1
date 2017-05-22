using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasteBookEF;
using System.Data.Entity;

namespace PasteBookDataAccess.Manager
{
    class Repository :IRepository

    {
        public virtual bool AddEntry<T>(T record) where T : class
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

        public virtual bool EditEntry<T>(T record) where T : class
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

        public virtual bool DeleteEntry<T>(T record) where T : class
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

        public virtual T RetrieveRecord<T>(Func<T, bool> condition) where T : class
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

        public virtual List<T> RetrieveListOfRecord<T>(Func<T, bool> condition) where T : class
        {
            List<T> listOfRecords = new List<T>;
            try
            {
                using (var context = new PasteBookEntities())
                {
                    IQueryable<T> query = context.Set<T>();
                    listOfRecords = query.Where(condition).ToList();
                }
            }catch(Exception ex)
            {
                return null;
            }
        }

        public virtual bool CheckIfRecordExist<T>(Func<T, bool> condition) where T : class
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

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public

    }
}
