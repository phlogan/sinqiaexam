using SinqiaExam.Data.DataContext;
using SinqiaExam.Domain.DTO;
using SinqiaExam.Domain.Entity;
using SinqiaExam.Domain.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SinqiaExam.Data.Repositories
{
    public class MovimentoManualRepository : BaseRepository<MovimentoManual>, IMovimentoManualRepository
    {

        public MovimentoManualRepository(SinqiaExamDataContext context) : base(context)
        {
        }

        public long GetLatestNumLancamento(int mes, int ano) =>
            _dbSet.Where(m => m.Data_mes == mes && m.Data_ano == ano).OrderByDescending(m => m.Num_lancamento).Select(m => m.Num_lancamento).FirstOrDefault();

        public IEnumerable<MovimentoManualListDTO> GetAllListDTO()
        {
            return _dbSet
                .Include(m => m.Produto)
                .Select(m => new MovimentoManualListDTO
                {
                    Cod_Produto = m.Cod_Produto,
                    Data_ano = m.Data_ano,
                    Num_lancamento = m.Num_lancamento,
                    Des_Descricao = m.Des_Descricao,
                    Data_mes = m.Data_mes,
                    Des_Produto = m.Produto.Des_produto,
                    Val_valor = m.Val_valor
                }).ToList();
        }
    }

}
