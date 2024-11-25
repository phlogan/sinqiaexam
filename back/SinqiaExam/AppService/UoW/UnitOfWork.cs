using SinqiaExam.Data.DataContext;
using System.Threading.Tasks;

namespace AppService.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SinqiaExamDataContext _context;
        public UnitOfWork(SinqiaExamDataContext context)
        {
            _context = context;
        }

        public int Commit() => _context.SaveChanges();

        public void Rollback() { }
    }
}
