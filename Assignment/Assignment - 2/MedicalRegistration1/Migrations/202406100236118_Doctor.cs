namespace MedicalRegistration1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Doctor : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Doctors", "DoctorName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Doctors", "DoctorName", c => c.Int(nullable: false));
        }
    }
}
