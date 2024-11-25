using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SinqiaExam.Domain.Interfaces;
using SinqiaExam.Domain.Services;
namespace SinqiaExam.Domain.Test.MovimentosManuais
{
    [TestClass]
    public class MovimentoManualServiceTest
    {
        private Mock<IMovimentoManualRepository> _repositoryMock;
        private MovimentoManualService _service;

        [TestInitialize]
        public void Setup()
        {
            _repositoryMock = new Mock<IMovimentoManualRepository>();
            _service = new MovimentoManualService(_repositoryMock.Object);
        }

        [TestMethod]
        public void GenerateNumLancamento_ShouldReturnNextCorrectNumber()
        {
            short mes = 11;
            short ano = 2024;
            long latestNumLancamento = 2;

            _repositoryMock
                .Setup(repo => repo.GetLatestNumLancamento(mes, ano))
                .Returns(latestNumLancamento);

            var proximoNumero = _service.GenerateNumLancamento(mes, ano);

            // Último lançamento (2) + 1
            Assert.AreEqual(3, proximoNumero);
        }

        [TestMethod]
        public void GenerateNumLancamento_ShouldReturn1OnceNumLancamentosIs0()
        {
            short mes = 11;
            short ano = 2024;
            long latestNumLancamento = 0;

            _repositoryMock
                .Setup(repo => repo.GetLatestNumLancamento(mes, ano))
                .Returns(latestNumLancamento);

            var proximoNumero = _service.GenerateNumLancamento(mes, ano);

            // Começar do 1 se não houver lançamentos
            Assert.AreEqual(1, proximoNumero);
        }
    }
}
