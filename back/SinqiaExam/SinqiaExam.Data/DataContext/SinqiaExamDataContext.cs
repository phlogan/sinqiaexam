using SinqiaExam.Data.EntityConfig;
using SinqiaExam.Domain.Entity;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SinqiaExam.Data.DataContext
{
    public class SinqiaExamDataContext : DbContext
    {

        public SinqiaExamDataContext() : base("name=SinqiaExamDbConnection")
        {

        }

        public override int SaveChanges() => base.SaveChanges();

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoCosif> Produto_Cosifs { get; set; }
        public DbSet<MovimentoManual> Movimento_Manuais { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new ProdutoConfig());
            modelBuilder.Configurations.Add(new ProdutoCosifConfig());
            modelBuilder.Configurations.Add(new MovimentoManualConfig());

            base.OnModelCreating(modelBuilder);
        }
    }

}
