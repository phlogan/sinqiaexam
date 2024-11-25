namespace SinqiaExam.Data.Migrations
{
    using SinqiaExam.Domain.Entity;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<SinqiaExam.Data.DataContext.SinqiaExamDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SinqiaExam.Data.DataContext.SinqiaExamDataContext context)
        {
            context.Produtos.AddOrUpdate(
            p => p.Cod_Produto,
                new Produto { Cod_Produto = "0001", Des_produto = "Produto A", Sta_Status = "A" },
                new Produto { Cod_Produto = "0002", Des_produto = "Produto B", Sta_Status = "I" },
                new Produto { Cod_Produto = "0003", Des_produto = "Produto C", Sta_Status = "A" }
            );

            context.Produto_Cosifs.AddOrUpdate(
                p => new { p.Cod_Produto, p.Cod_Cosif },
                new ProdutoCosif { Cod_Produto = "0001", Cod_Cosif = "COS123", Cod_Classificacao = "CL001", Sta_Status = "A" },
                new ProdutoCosif { Cod_Produto = "0002", Cod_Cosif = "COS124", Cod_Classificacao = "CL002", Sta_Status = "I" },
                new ProdutoCosif { Cod_Produto = "0003", Cod_Cosif = "COS125", Cod_Classificacao = "CL003", Sta_Status = "A" }
            );

            base.Seed(context);
        }
    }
}
