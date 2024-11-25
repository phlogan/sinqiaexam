using SinqiaExam.CrossCutting.Validation;
using SinqiaExam.Domain.DTO;
using SinqiaExam.Domain.Entity;
using SinqiaExam.Domain.Interfaces;
using SinqiaExam.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace SinqiaExam.Domain.Services
{
    public class MovimentoManualService : IMovimentoManualService
    {
        private readonly IMovimentoManualRepository _movimentoManualRepository;
        public MovimentoManualService(IMovimentoManualRepository movimentoManualRepository)
        {
            _movimentoManualRepository = movimentoManualRepository;
        }

        public SinqiaValidationResult Add(MovimentoManual movimentoManual)
        {
            MovimentoManualSet(movimentoManual);
            var validationResult = MovimentoManualValidate(movimentoManual);

            if (validationResult.IsValid)
                _movimentoManualRepository.Add(movimentoManual);

            return validationResult;
        }

        public long GenerateNumLancamento(int mes, int ano)
        {
            return _movimentoManualRepository.GetLatestNumLancamento(mes, ano) + 1;
        }


        public IEnumerable<MovimentoManualListDTO> GetAllListDTO() => _movimentoManualRepository.GetAllListDTO();

        #region :: Métodos Privados
        private void MovimentoManualSet(MovimentoManual movimentoManual)
        {
            movimentoManual.Num_lancamento = GenerateNumLancamento(movimentoManual.Data_mes, movimentoManual.Data_ano);
            movimentoManual.Dat_movimento = DateTime.UtcNow;
            movimentoManual.Cod_usuario = "TESTE";
        }

        private SinqiaValidationResult MovimentoManualValidate(MovimentoManual movimentoManual)
        {
            var result = new SinqiaValidationResult();
            result.AddIf(movimentoManual.Data_mes <= 0, "O mês deve ser maior que 0");
            result.AddIf(movimentoManual.Data_ano <= 0, "O ano deve ser maior que 0");
            result.AddIf(string.IsNullOrWhiteSpace(movimentoManual.Cod_Produto), "O código do produto deve ser informado");
            result.AddIf(string.IsNullOrWhiteSpace(movimentoManual.Cod_Cosif), "O Cod_Cosif deve ser informado");

            return result;
        }
        #endregion
    }
}
