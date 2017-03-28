namespace pc2x.Application.Repositories.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Relaciones : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Estados",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Codigo = c.String(),
                        PaisId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Paises", t => t.PaisId, cascadeDelete: true)
                .Index(t => t.PaisId);

            CreateTable(
                "dbo.Municipios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Codigo = c.String(),
                        EstadoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Estados", t => t.EstadoId, cascadeDelete: true)
                .Index(t => t.EstadoId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Estados", "PaisId", "dbo.Paises");
            DropForeignKey("dbo.Municipios", "EstadoId", "dbo.Estados");
            DropIndex("dbo.Municipios", new[] { "EstadoId" });
            DropIndex("dbo.Estados", new[] { "PaisId" });
            DropTable("dbo.Municipios");
            DropTable("dbo.Estados");
        }
    }
}
