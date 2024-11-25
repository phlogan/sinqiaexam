using AppService.DTO;
using AppService.Interfaces;
using AppService.UoW;
using SinqiaExam.CrossCutting.Validation;
using SinqiaExam.Domain.Entity;
using SinqiaExam.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace AppService.AppServices
{
    public class MovimentoManualAppService : BaseAppService, IMovimentoManualAppService
    {
        private readonly IMovimentoManualService _movimentoManualService;
        public MovimentoManualAppService(IUnitOfWork uow, IMovimentoManualService movimentoManualService) : base(uow)
        {
            _movimentoManualService = movimentoManualService;
        }

        public SinqiaValidationResult Add(MovimentoManualManageDTO movimentoManual)
        {
            var model = new MovimentoManual();
            model.Data_mes = movimentoManual.Data_mes;
            model.Data_ano = movimentoManual.Data_ano;
            model.Cod_Produto = movimentoManual.Cod_Produto;
            model.Cod_Cosif = movimentoManual.Cod_Cosif;
            model.Des_Descricao = movimentoManual.Des_Descricao;
            model.Val_valor = movimentoManual.Val_valor;

            var result = _movimentoManualService.Add(model);
            if(result.IsValid)
                SaveChanges();
            return result;
        }

        public IEnumerable<MovimentoManualListDTO> GetAllListDTO() => _movimentoManualService.GetAllListDTO().Select(m => new MovimentoManualListDTO
        {
            Cod_Produto = m.Cod_Produto,
            Data_ano = m.Data_ano,
            Num_lancamento = m.Num_lancamento,
            Des_Descricao = m.Des_Descricao,
            Data_mes = m.Data_mes,
            Des_Produto = m.Des_Produto,
            Val_valor = m.Val_valor
        });
    }
}
