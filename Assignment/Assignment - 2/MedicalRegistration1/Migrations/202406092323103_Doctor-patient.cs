namespace MedicalRegistration1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Doctorpatient : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        DoctorId = c.Int(nullable: false, identity: true),
                        DoctorName = c.Int(nullable: false),
                        Specialization = c.String(),
                    })
                .PrimaryKey(t => t.DoctorId);
            
            CreateTable(
                "dbo.DoctorPatients",
                c => new
                    {
                        Doctor_DoctorId = c.Int(nullable: false),
                        Patient_PatientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Doctor_DoctorId, t.Patient_PatientId })
                .ForeignKey("dbo.Doctors", t => t.Doctor_DoctorId, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.Patient_PatientId, cascadeDelete: true)
                .Index(t => t.Doctor_DoctorId)
                .Index(t => t.Patient_PatientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DoctorPatients", "Patient_PatientId", "dbo.Patients");
            DropForeignKey("dbo.DoctorPatients", "Doctor_DoctorId", "dbo.Doctors");
            DropIndex("dbo.DoctorPatients", new[] { "Patient_PatientId" });
            DropIndex("dbo.DoctorPatients", new[] { "Doctor_DoctorId" });
            DropTable("dbo.DoctorPatients");
            DropTable("dbo.Doctors");
        }
    }
}
