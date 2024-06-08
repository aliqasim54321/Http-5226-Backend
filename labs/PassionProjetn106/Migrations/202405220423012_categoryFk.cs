namespace PassionProjetn106.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categoryFk : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ExerciseEquipments", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.ExerciseEquipments", "CategoryId");
            AddForeignKey("dbo.ExerciseEquipments", "CategoryId", "dbo.Categories", "CategoriaId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExerciseEquipments", "CategoryId", "dbo.Categories");
            DropIndex("dbo.ExerciseEquipments", new[] { "CategoryId" });
            DropColumn("dbo.ExerciseEquipments", "CategoryId");
        }
    }
}
