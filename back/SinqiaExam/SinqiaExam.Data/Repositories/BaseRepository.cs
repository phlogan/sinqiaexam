using SinqiaExam.Data.DataContext;
using SinqiaExam.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SinqiaExam.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly SinqiaExamDataContext db;
        protected readonly DbSet<T> _dbSet;

        public BaseRepository(SinqiaExamDataContext context)
        {
            db = context;
            _dbSet = db.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T Add(T entity) => _dbSet.Add(entity);
    }
}