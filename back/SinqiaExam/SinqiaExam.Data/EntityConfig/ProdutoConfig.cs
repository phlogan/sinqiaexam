using SinqiaExam.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace SinqiaExam.Data.EntityConfig
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {
            HasKey(p => p.Cod_Produto);

            Property(p => p.Cod_Produto)
                .HasColumnType("char")
                .HasMaxLength(4)
                .IsRequired();

            Property(p => p.Des_produto)
                .HasColumnType("varchar")
                .HasMaxLength(30)
                .IsOptional();

            Property(p => p.Sta_Status)
                .HasColumnType("char")
                .HasMaxLength(1)
                .IsOptional();

            ToTable("Produto");
        }
    }
}
