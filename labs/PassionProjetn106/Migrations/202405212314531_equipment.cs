namespace PassionProjetn106.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class equipment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExerciseEquipments",
                c => new
                    {
                        EquipmentId = c.Int(nullable: false, identity: true),
                        EquipmentWeight = c.Int(nullable: false),
                        EquipmentName = c.String(),
                    })
                .PrimaryKey(t => t.EquipmentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ExerciseEquipments");
        }
    }
}
