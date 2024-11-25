using AppService.UoW;

namespace AppService.AppServices
{
    public class BaseAppService
    {
        private readonly IUnitOfWork _uow;
        public BaseAppService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        protected void SaveChanges() => _uow.Commit();
    }
}
