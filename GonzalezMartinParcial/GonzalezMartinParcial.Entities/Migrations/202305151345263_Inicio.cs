namespace GonzalezMartinParcial.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departamentoes",
                c => new
                    {
                        DepartamentoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.DepartamentoId);
            
            CreateTable(
                "dbo.Municipios",
                c => new
                    {
                        MunicipioId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        DepartamentoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MunicipioId)
                .ForeignKey("dbo.Departamentoes", t => t.DepartamentoId)
                .Index(t => t.DepartamentoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Municipios", "DepartamentoId", "dbo.Departamentoes");
            DropIndex("dbo.Municipios", new[] { "DepartamentoId" });
            DropTable("dbo.Municipios");
            DropTable("dbo.Departamentoes");
        }
    }
}
