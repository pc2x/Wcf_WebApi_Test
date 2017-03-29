namespace pc2x.Application.Repositories.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class CodigoPostal_Asentamiento_Tables : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Estados", newName: "Estados");
            CreateTable(
                "dbo.Asentamientos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        MunicipioId = c.Int(nullable: false),
                        TipoAsentamiento_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Municipios", t => t.MunicipioId, cascadeDelete: true)
                .ForeignKey("dbo.TipoAsentamientos", t => t.TipoAsentamiento_Id, cascadeDelete: true)
                .Index(t => t.Nombre, unique: true)
                .Index(t => t.MunicipioId)
                .Index(t => t.TipoAsentamiento_Id);

            CreateTable(
                "dbo.TipoAsentamientos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Nombre, unique: true);

            CreateTable(
                "dbo.CodigosPostales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 7, unicode: false),
                        Asentamiento_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Asentamientos", t => t.Asentamiento_Id, cascadeDelete: true)
                .Index(t => t.Codigo, unique: true)
                .Index(t => t.Asentamiento_Id);

            AlterColumn("dbo.Estados", "Nombre", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Estados", "Codigo", c => c.String(nullable: false, maxLength: 5));
            AlterColumn("dbo.Municipios", "Nombre", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Municipios", "Codigo", c => c.String(nullable: false, maxLength: 5));
        }

        public override void Down()
        {
            DropForeignKey("dbo.CodigosPostales", "Asentamiento_Id", "dbo.Asentamientos");
            DropForeignKey("dbo.Asentamientos", "TipoAsentamiento_Id", "dbo.TipoAsentamientos");
            DropForeignKey("dbo.Asentamientos", "MunicipioId", "dbo.Municipios");
            DropIndex("dbo.CodigosPostales", new[] { "Asentamiento_Id" });
            DropIndex("dbo.CodigosPostales", new[] { "Codigo" });
            DropIndex("dbo.TipoAsentamientos", new[] { "Nombre" });
            DropIndex("dbo.Asentamientos", new[] { "TipoAsentamiento_Id" });
            DropIndex("dbo.Asentamientos", new[] { "MunicipioId" });
            DropIndex("dbo.Asentamientos", new[] { "Nombre" });
            AlterColumn("dbo.Municipios", "Codigo", c => c.String());
            AlterColumn("dbo.Municipios", "Nombre", c => c.String());
            AlterColumn("dbo.Estados", "Codigo", c => c.String());
            AlterColumn("dbo.Estados", "Nombre", c => c.String());
            DropTable("dbo.CodigosPostales");
            DropTable("dbo.TipoAsentamientos");
            DropTable("dbo.Asentamientos");
            RenameTable(name: "dbo.Estados", newName: "Estadoes");
        }
    }
}
