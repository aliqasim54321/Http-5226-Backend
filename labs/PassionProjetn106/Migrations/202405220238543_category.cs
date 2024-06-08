namespace PassionProjetn106.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class category : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoriaId = c.Int(nullable: false, identity: true),
                        CategoriaName = c.String(),
                    })
                .PrimaryKey(t => t.CategoriaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
