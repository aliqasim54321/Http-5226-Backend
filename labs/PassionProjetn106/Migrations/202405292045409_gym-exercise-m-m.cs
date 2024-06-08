namespace PassionProjetn106.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gymexercisemm : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GymExerciseEquipments",
                c => new
                    {
                        Gym_GymId = c.Int(nullable: false),
                        ExerciseEquipment_EquipmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Gym_GymId, t.ExerciseEquipment_EquipmentId })
                .ForeignKey("dbo.Gyms", t => t.Gym_GymId, cascadeDelete: true)
                .ForeignKey("dbo.ExerciseEquipments", t => t.ExerciseEquipment_EquipmentId, cascadeDelete: true)
                .Index(t => t.Gym_GymId)
                .Index(t => t.ExerciseEquipment_EquipmentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GymExerciseEquipments", "ExerciseEquipment_EquipmentId", "dbo.ExerciseEquipments");
            DropForeignKey("dbo.GymExerciseEquipments", "Gym_GymId", "dbo.Gyms");
            DropIndex("dbo.GymExerciseEquipments", new[] { "ExerciseEquipment_EquipmentId" });
            DropIndex("dbo.GymExerciseEquipments", new[] { "Gym_GymId" });
            DropTable("dbo.GymExerciseEquipments");
        }
    }
}
