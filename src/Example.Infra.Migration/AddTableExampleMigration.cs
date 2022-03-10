using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Data.Entity.Migrations;

namespace Example.Infra.Migration
{
    public partial class AddTableExampleMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Example",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 200),
                    Agee = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropTable("dbo.Example");
        }
    }
}
