namespace AppService.DTO
{
    public class MovimentoManualListDTO
    {
        public MovimentoManualListDTO()
        {

        }
        public short Data_mes { get; set; }
        public short Data_ano { get; set; }
        public long Num_lancamento { get; set; }
        public string Cod_Produto { get; set; }
        public string Des_Descricao { get; set; }
        public string Des_Produto { get; set; }
        public decimal Val_valor { get; set; }
    }
}
