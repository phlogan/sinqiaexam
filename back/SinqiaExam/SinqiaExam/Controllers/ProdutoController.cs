using AppService.Interfaces;
using Swashbuckle.Swagger.Annotations;
using System.Collections.Generic;
using System.Web.Http;

namespace SinqiaExam.Controllers
{
    [Route("api/produto")]
    public class ProdutoController : ApiController
    {
        private readonly IProdutoAppService _produtoAppService;
        public ProdutoController(IProdutoAppService produtoAppService)
        {
            _produtoAppService = produtoAppService;
        }

        /// <summary>
        /// Retorna um dicionário de Cod_Produto / Des_Produto
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/produto/enumerate")]
        [SwaggerResponse(200, Type = typeof(IReadOnlyDictionary<string, string>))]
        public IHttpActionResult Get()
        {
            return Ok(_produtoAppService.GetProdutoEnumeration());
        }

        /// <summary>
        /// Retorna um dicionário de Cod_Cosif / Cod_Classificacao
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/produto/enumerate/cosif/{cod_produto}")]
        [SwaggerResponse(200, Type = typeof(IReadOnlyDictionary<string, string>))]
        public IHttpActionResult GetCosifByCod_Produto([FromUri] string cod_produto)
        {
            return Ok(_produtoAppService.GetCosifEnumeration(cod_produto));
        }
    }
}