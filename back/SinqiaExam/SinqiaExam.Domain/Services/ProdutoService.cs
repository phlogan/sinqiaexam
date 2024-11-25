using SinqiaExam.Domain.Interfaces.Repositories;
using SinqiaExam.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace SinqiaExam.Domain.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IReadOnlyDictionary<string, string> GetCosifEnumeration(string cod_produto)
            => _produtoRepository.GetCosifEnumeration(cod_produto);

        public IReadOnlyDictionary<string, string> GetProdutoEnumeration()
            => _produtoRepository.GetProdutoEnumeration();
    }
}
