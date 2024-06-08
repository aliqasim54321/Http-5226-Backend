namespace PassionProjetn106.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EquipmentPrice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ExerciseEquipments", "EquipmentPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ExerciseEquipments", "EquipmentPrice");
        }
    }
}
