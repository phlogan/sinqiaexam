using SinqiaExam.Domain.DTO;
using SinqiaExam.Domain.Entity;
using SinqiaExam.Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace SinqiaExam.Domain.Interfaces
{
    public interface IMovimentoManualRepository : IBaseRepository<MovimentoManual>
    {
        long GetLatestNumLancamento(int mes, int ano);
        IEnumerable<MovimentoManualListDTO> GetAllListDTO();
    }
}
