using SinqiaExam.Data.DataContext;
using SinqiaExam.Domain.Entity;
using SinqiaExam.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace SinqiaExam.Data.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {

        public ProdutoRepository(SinqiaExamDataContext context) : base(context)
        {
        }

        public IReadOnlyDictionary<string, string> GetCosifEnumeration(string cod_produto)
            => db.Produto_Cosifs.Where(m => m.Cod_Produto == cod_produto)
                .ToDictionary(key => key.Cod_Cosif, value => value.Cod_Classificacao);

        public IReadOnlyDictionary<string, string> GetProdutoEnumeration()
            => _dbSet.ToDictionary(key => key.Cod_Produto, value => value.Des_produto);
    }
}
