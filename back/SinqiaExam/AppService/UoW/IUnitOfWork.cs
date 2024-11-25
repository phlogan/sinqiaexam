using System.Threading.Tasks;

namespace AppService.UoW
{
    public interface IUnitOfWork
    {
        int Commit();
        void Rollback();
    }
}
