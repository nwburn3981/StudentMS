using Microsoft.EntityFrameworkCore;
using StuMSAPI.Data;
using StuMSAPI.Repo.IRepo;
using System.Linq.Expressions;

namespace StuMSAPI.Repo
{
    public class Repo<T> : IRepo<T> where T: class
    {
        private readonly ApplicationDbContext _db;

        internal DbSet<T> dbSet;

        public Repo(ApplicationDbContext db)
        {
            _db = db;
            this.dbSet = db.Set<T>();
        }

        void IRepo<T>.Add(T item)
        {
            dbSet.Add(item);
        }

        void IRepo<T>.Update(T item)
        { 
            dbSet.Update(item);
        }

         IEnumerable<T> IRepo<T>.GetAll()
        {
            IQueryable<T> query = dbSet;
            return query.ToList();
        }

        T IRepo<T>.GetFirstOrDefault(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet.Where(filter);

            return query.FirstOrDefault();
            
        }

        void IRepo<T>.Remove(T item)
        {
            dbSet.Remove(item);
        }

        public void RemoveRange(IEnumerable<T> items)
        {
            dbSet.RemoveRange(items);
        }
    }
}
