namespace pc2x.Application.Repositories.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class CreateDatabaseAndFirstTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Paises",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Codigo = c.String(nullable: false, maxLength: 5),
                    })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropTable("dbo.Paises");
        }
    }
}
