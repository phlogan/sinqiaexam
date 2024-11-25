using AppService.Interfaces;
using AppService.UoW;
using SinqiaExam.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace AppService.AppServices
{
    public class ProdutoAppService : BaseAppService, IProdutoAppService
    {
        private readonly IProdutoService _produto;
        public ProdutoAppService(IUnitOfWork uow, IProdutoService produto) : base(uow)
        {
            _produto = produto;
        }

        public IReadOnlyDictionary<string, string> GetProdutoEnumeration() => _produto.GetProdutoEnumeration();
        public IReadOnlyDictionary<string, string> GetCosifEnumeration(string cod_produto) => _produto.GetCosifEnumeration(cod_produto);
    }
}
