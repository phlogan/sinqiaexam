using SinqiaExam.CrossCutting.Validation;
using SinqiaExam.Domain.DTO;
using SinqiaExam.Domain.Entity;
using System.Collections.Generic;

namespace SinqiaExam.Domain.Interfaces.Services
{
    public interface IMovimentoManualService
    {
        SinqiaValidationResult Add(MovimentoManual movimentoManual);
        long GenerateNumLancamento(int mes, int ano);
        IEnumerable<MovimentoManualListDTO> GetAllListDTO();
    } 
}
