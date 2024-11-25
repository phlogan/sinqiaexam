using System.Collections.Generic;

namespace SinqiaExam.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T>
    {
        IEnumerable<T> GetAll();
        T Add(T entity);
    }
}
