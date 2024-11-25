namespace SinqiaExam.Domain.Entity
{
    public class ProdutoCosif
    {
        public ProdutoCosif()
        {

        }
        public string Cod_Produto { get; set; }
        public string Cod_Cosif { get; set; }
        public string Cod_Classificacao { get; set; }
        public string Sta_Status { get; set; }

        public Produto Produto { get; set; }
    }
}
