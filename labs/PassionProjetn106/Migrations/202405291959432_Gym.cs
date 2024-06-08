namespace PassionProjetn106.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Gym : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Gyms",
                c => new
                    {
                        GymId = c.Int(nullable: false, identity: true),
                        GymName = c.String(),
                        GymAddress = c.String(),
                    })
                .PrimaryKey(t => t.GymId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Gyms");
        }
    }
}
