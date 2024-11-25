using AppService.DTO;
using AppService.Interfaces;
using SinqiaExam.CrossCutting.Validation;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace SinqiaExam.Controllers
{
    [Route("api/movimentos_manuais")]
    public class MovimentosManuaisController : ApiController
    {
        private readonly IMovimentoManualAppService _movimentoManualAppService;
        public MovimentosManuaisController(IMovimentoManualAppService movimentoManualAppService)
        {
            _movimentoManualAppService = movimentoManualAppService;
        }

        [HttpPost]
        [SwaggerResponse(200)]
        [SwaggerResponse(400, Type = typeof(SinqiaValidationResult))]
        public IHttpActionResult Include([FromBody] MovimentoManualManageDTO model)
        {
            try
            {
                var result = _movimentoManualAppService.Add(model);

                if (result.IsValid)
                    return Ok();

                return Content(System.Net.HttpStatusCode.BadRequest, result);
            }
            catch(Exception ex)
            {
                return InternalServerError();
            }
        }

        [HttpGet]
        [SwaggerResponse(200, Type = typeof(IEnumerable<MovimentoManualListDTO>))]
        public IHttpActionResult Get()
        {
            return Ok(_movimentoManualAppService.GetAllListDTO());
        }
    }
}