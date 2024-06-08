namespace PassionProjetn106.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class exereciseEquipment : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ExerciseEquipments", "CategoryId", "dbo.Categories");
            DropPrimaryKey("dbo.Categories");
            AddColumn("dbo.Categories", "CategoryId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Categories", "CategoryName", c => c.String());
            AddPrimaryKey("dbo.Categories", "CategoryId");
            AddForeignKey("dbo.ExerciseEquipments", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
            DropColumn("dbo.Categories", "CategoriaId");
            DropColumn("dbo.Categories", "CategoriaName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "CategoriaName", c => c.String());
            AddColumn("dbo.Categories", "CategoriaId", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.ExerciseEquipments", "CategoryId", "dbo.Categories");
            DropPrimaryKey("dbo.Categories");
            DropColumn("dbo.Categories", "CategoryName");
            DropColumn("dbo.Categories", "CategoryId");
            AddPrimaryKey("dbo.Categories", "CategoriaId");
            AddForeignKey("dbo.ExerciseEquipments", "CategoryId", "dbo.Categories", "CategoriaId", cascadeDelete: true);
        }
    }
}
