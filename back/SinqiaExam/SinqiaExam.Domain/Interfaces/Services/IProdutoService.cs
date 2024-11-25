using System.Collections.Generic;

namespace SinqiaExam.Domain.Interfaces.Services
{
    public interface IProdutoService
    {
        IReadOnlyDictionary<string, string> GetProdutoEnumeration();
        IReadOnlyDictionary<string, string> GetCosifEnumeration(string cod_produto);
    }
}
