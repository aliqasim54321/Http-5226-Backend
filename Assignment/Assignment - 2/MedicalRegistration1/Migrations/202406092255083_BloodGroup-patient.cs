namespace MedicalRegistration1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BloodGrouppatient : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "BloodGroupID", c => c.Int(nullable: false));
            CreateIndex("dbo.Patients", "BloodGroupID");
            AddForeignKey("dbo.Patients", "BloodGroupID", "dbo.BloodGroups", "BloodGroupId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Patients", "BloodGroupID", "dbo.BloodGroups");
            DropIndex("dbo.Patients", new[] { "BloodGroupID" });
            DropColumn("dbo.Patients", "BloodGroupID");
        }
    }
}
