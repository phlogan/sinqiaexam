using AppService.DTO;
using SinqiaExam.CrossCutting.Validation;
using System.Collections.Generic;

namespace AppService.Interfaces
{
    public interface IMovimentoManualAppService
    {
        SinqiaValidationResult Add(MovimentoManualManageDTO movimentoManual);
        IEnumerable<MovimentoManualListDTO> GetAllListDTO();
    }
}
