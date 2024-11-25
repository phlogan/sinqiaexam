using AppService.AppServices;
using AppService.Interfaces;
using AppService.UoW;
using SimpleInjector;
using SinqiaExam.Data.DataContext;
using SinqiaExam.Data.Repositories;
using SinqiaExam.Domain.Interfaces;
using SinqiaExam.Domain.Interfaces.Repositories;
using SinqiaExam.Domain.Interfaces.Services;
using SinqiaExam.Domain.Services;

namespace SinqiaExam.IoC
{
    public class Injector
    {
        public static void RegisterServices(Container container)
        {
            container.Register<SinqiaExamDataContext>(Lifestyle.Scoped);
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);

            container.Register<IMovimentoManualRepository, MovimentoManualRepository>(Lifestyle.Scoped);
            container.Register<IMovimentoManualService, MovimentoManualService>(Lifestyle.Scoped);
            container.Register<IMovimentoManualAppService, MovimentoManualAppService>(Lifestyle.Scoped);


            container.Register<IProdutoRepository, ProdutoRepository>(Lifestyle.Scoped);
            container.Register<IProdutoService, ProdutoService>(Lifestyle.Scoped);
            container.Register<IProdutoAppService, ProdutoAppService>(Lifestyle.Scoped);
        }
    }
}
