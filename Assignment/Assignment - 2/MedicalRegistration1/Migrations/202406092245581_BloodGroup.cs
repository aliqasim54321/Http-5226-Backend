namespace MedicalRegistration1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BloodGroup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BloodGroups",
                c => new
                    {
                        BloodGroupId = c.Int(nullable: false, identity: true),
                        BloodGroupName = c.String(),
                    })
                .PrimaryKey(t => t.BloodGroupId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BloodGroups");
        }
    }
}
