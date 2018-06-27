namespace Laba5_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Instytyts",
                c => new
                    {
                        Instytyts_id = c.Int(nullable: false, identity: true),
                        Instytyts_name = c.String(),
                        Director = c.String(),
                    })
                .PrimaryKey(t => t.Instytyts_id);
            
            CreateTable(
                "dbo.Kafedras",
                c => new
                    {
                        Kafedra_id = c.Int(nullable: false, identity: true),
                        Kafedra_name = c.String(),
                        Kafedra_zav = c.String(),
                        Count_Doctor_Science = c.Int(nullable: false),
                        Instytyts_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Kafedra_id);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Subject_id = c.Int(nullable: false, identity: true),
                        Subject_name = c.String(),
                        Subject_hour = c.Int(nullable: false),
                        Subject_Type_Ex = c.String(),
                    })
                .PrimaryKey(t => t.Subject_id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Teachers_id = c.Int(nullable: false, identity: true),
                        Teachers_name = c.String(),
                        Teachers_age = c.Int(nullable: false),
                        Teachers_level = c.String(),
                        Teachers_phone = c.String(),
                        Kafedra_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Teachers_id);
            
            CreateTable(
                "dbo.TeachersSubjects",
                c => new
                    {
                        Teachers_Teachers_id = c.Int(nullable: false),
                        Subjects_Subject_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Teachers_Teachers_id, t.Subjects_Subject_id })
                .ForeignKey("dbo.Teachers", t => t.Teachers_Teachers_id, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.Subjects_Subject_id, cascadeDelete: true)
                .Index(t => t.Teachers_Teachers_id)
                .Index(t => t.Subjects_Subject_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeachersSubjects", "Subjects_Subject_id", "dbo.Subjects");
            DropForeignKey("dbo.TeachersSubjects", "Teachers_Teachers_id", "dbo.Teachers");
            DropIndex("dbo.TeachersSubjects", new[] { "Subjects_Subject_id" });
            DropIndex("dbo.TeachersSubjects", new[] { "Teachers_Teachers_id" });
            DropTable("dbo.TeachersSubjects");
            DropTable("dbo.Teachers");
            DropTable("dbo.Subjects");
            DropTable("dbo.Kafedras");
            DropTable("dbo.Instytyts");
        }
    }
}
