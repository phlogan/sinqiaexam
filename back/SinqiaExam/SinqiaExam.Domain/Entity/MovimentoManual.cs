using System;

namespace SinqiaExam.Domain.Entity
{
    public class MovimentoManual
    {
        public MovimentoManual()
        {

        }
        public short Data_mes { get; set; }
        public short Data_ano { get; set; }
        public long Num_lancamento { get; set; }
        public string Cod_Produto { get; set; }
        public string Cod_Cosif { get; set; }
        public string Des_Descricao { get; set; }
        public DateTime Dat_movimento { get; set; }
        public string Cod_usuario { get; set; }
        public decimal Val_valor { get; set; }

        public Produto Produto { get; set; }
        public ProdutoCosif Produto_Cosif { get; set; }
    }

}
