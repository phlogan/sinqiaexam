using SinqiaExam.Domain.Entity;
using System.Data.Entity.ModelConfiguration;


namespace SinqiaExam.Data.EntityConfig
{
    public class MovimentoManualConfig : EntityTypeConfiguration<MovimentoManual>
    {
        public MovimentoManualConfig()
        {
            HasKey(m => new { m.Data_mes, m.Data_ano, m.Num_lancamento, m.Cod_Produto, m.Cod_Cosif });

            Property(m => m.Data_mes)
                .IsRequired();

            Property(m => m.Data_ano).IsRequired();

            Property(m => m.Num_lancamento).IsRequired();

            Property(m => m.Cod_Produto)
                .HasColumnType("char")
                .HasMaxLength(4)
                .IsRequired();

            Property(m => m.Cod_Cosif)
                .HasColumnType("char")
                .HasMaxLength(11)
                .IsRequired();

            Property(m => m.Des_Descricao)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(m => m.Dat_movimento)
                .HasColumnType("smalldatetime")
                .IsRequired();

            Property(m => m.Cod_usuario)
                .HasColumnType("varchar")
                .HasMaxLength(15)
                .IsRequired();

            Property(m => m.Val_valor)
                .HasColumnType("numeric")
                .HasPrecision(18, 2)
                .IsRequired();

            ToTable("Movimento_Manual");
        }
    }

}
