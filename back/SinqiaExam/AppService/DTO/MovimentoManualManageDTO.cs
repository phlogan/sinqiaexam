namespace AppService.DTO
{
    public class MovimentoManualManageDTO
    {
        public short Data_mes { get; set; }
        public short Data_ano { get; set; }
        public string Cod_Produto { get; set; }
        public string Cod_Cosif { get; set; }
        public string Des_Descricao { get; set; }
        public decimal Val_valor { get; set; }
    }
}
