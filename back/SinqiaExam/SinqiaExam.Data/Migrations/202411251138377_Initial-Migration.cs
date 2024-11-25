namespace SinqiaExam.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movimento_Manual",
                c => new
                    {
                        Data_mes = c.Short(nullable: false),
                        Data_ano = c.Short(nullable: false),
                        Num_lancamento = c.Long(nullable: false),
                        Cod_Produto = c.String(nullable: false, maxLength: 4, fixedLength: true, unicode: false),
                        Cod_Cosif = c.String(nullable: false, maxLength: 11, fixedLength: true, unicode: false),
                        Des_Descricao = c.String(nullable: false, maxLength: 50, unicode: false),
                        Dat_movimento = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        Cod_usuario = c.String(nullable: false, maxLength: 15, unicode: false),
                        Val_valor = c.Decimal(nullable: false, precision: 18, scale: 2, storeType: "numeric"),
                    })
                .PrimaryKey(t => new { t.Data_mes, t.Data_ano, t.Num_lancamento, t.Cod_Produto, t.Cod_Cosif })
                .ForeignKey("dbo.Produto", t => t.Cod_Produto)
                .ForeignKey("dbo.Produto_Cosif", t => new { t.Cod_Produto, t.Cod_Cosif })
                .Index(t => t.Cod_Produto)
                .Index(t => new { t.Cod_Produto, t.Cod_Cosif });
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        Cod_Produto = c.String(nullable: false, maxLength: 4, fixedLength: true, unicode: false),
                        Des_produto = c.String(maxLength: 30, unicode: false),
                        Sta_Status = c.String(maxLength: 1, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.Cod_Produto);
            
            CreateTable(
                "dbo.Produto_Cosif",
                c => new
                    {
                        Cod_Produto = c.String(nullable: false, maxLength: 4, fixedLength: true, unicode: false),
                        Cod_Cosif = c.String(nullable: false, maxLength: 11, fixedLength: true, unicode: false),
                        Cod_Classificacao = c.String(maxLength: 6, fixedLength: true, unicode: false),
                        Sta_Status = c.String(maxLength: 1, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => new { t.Cod_Produto, t.Cod_Cosif })
                .ForeignKey("dbo.Produto", t => t.Cod_Produto)
                .Index(t => t.Cod_Produto);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movimento_Manual", new[] { "Cod_Produto", "Cod_Cosif" }, "dbo.Produto_Cosif");
            DropForeignKey("dbo.Produto_Cosif", "Cod_Produto", "dbo.Produto");
            DropForeignKey("dbo.Movimento_Manual", "Cod_Produto", "dbo.Produto");
            DropIndex("dbo.Produto_Cosif", new[] { "Cod_Produto" });
            DropIndex("dbo.Movimento_Manual", new[] { "Cod_Produto", "Cod_Cosif" });
            DropIndex("dbo.Movimento_Manual", new[] { "Cod_Produto" });
            DropTable("dbo.Produto_Cosif");
            DropTable("dbo.Produto");
            DropTable("dbo.Movimento_Manual");
        }
    }
}
