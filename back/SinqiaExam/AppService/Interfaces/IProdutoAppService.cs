using System.Collections.Generic;

namespace AppService.Interfaces
{
    public interface IProdutoAppService
    {
        IReadOnlyDictionary<string, string> GetProdutoEnumeration();
        IReadOnlyDictionary<string, string> GetCosifEnumeration(string cod_produto);
    }
}
