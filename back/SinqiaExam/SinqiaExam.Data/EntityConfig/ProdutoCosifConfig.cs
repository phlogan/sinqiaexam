using SinqiaExam.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace SinqiaExam.Data.EntityConfig
{
    public class ProdutoCosifConfig : EntityTypeConfiguration<ProdutoCosif>
    {
        public ProdutoCosifConfig()
        {
            HasKey(pc => new { pc.Cod_Produto, pc.Cod_Cosif });

            Property(pc => pc.Cod_Produto)
                .HasColumnType("char")
                .HasMaxLength(4)
                .IsRequired();

            Property(pc => pc.Cod_Cosif)
                .HasColumnType("char")
                .HasMaxLength(11)
                .IsRequired();

            Property(pc => pc.Cod_Classificacao)
                .HasColumnType("char")
                .HasMaxLength(6)
                .IsOptional();

            Property(pc => pc.Sta_Status)
                .HasColumnType("char")
                .HasMaxLength(1)
                .IsOptional();

            ToTable("Produto_Cosif");
        }
    }
}
