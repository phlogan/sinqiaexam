using System.Collections.Generic;

namespace SinqiaExam.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository
    {
        IReadOnlyDictionary<string, string> GetCosifEnumeration(string cod_produto);
        IReadOnlyDictionary<string, string> GetProdutoEnumeration();
    }
}
