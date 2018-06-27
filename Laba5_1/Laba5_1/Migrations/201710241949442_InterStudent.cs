namespace Laba5_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InterStudent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InterStudents",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Student_name = c.String(maxLength: 25),
                        Student_age = c.Int(nullable: false),
                        Students_ticket = c.String(maxLength: 25),
                    })
                .PrimaryKey(t => t.id);
            
            AlterColumn("dbo.Instytyts", "Instytyts_name", c => c.String(maxLength: 25));
            AlterColumn("dbo.Instytyts", "Director", c => c.String(maxLength: 25));
            AlterColumn("dbo.Kafedras", "Kafedra_name", c => c.String(maxLength: 25));
            AlterColumn("dbo.Kafedras", "Kafedra_zav", c => c.String(maxLength: 25));
            AlterColumn("dbo.Subjects", "Subject_name", c => c.String(maxLength: 30));
            AlterColumn("dbo.Subjects", "Subject_Type_Ex", c => c.String(maxLength: 15));
            AlterColumn("dbo.Teachers", "Teachers_name", c => c.String(maxLength: 25));
            AlterColumn("dbo.Teachers", "Teachers_level", c => c.String(maxLength: 25));
            AlterColumn("dbo.Teachers", "Teachers_phone", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Teachers", "Teachers_phone", c => c.String());
            AlterColumn("dbo.Teachers", "Teachers_level", c => c.String());
            AlterColumn("dbo.Teachers", "Teachers_name", c => c.String());
            AlterColumn("dbo.Subjects", "Subject_Type_Ex", c => c.String());
            AlterColumn("dbo.Subjects", "Subject_name", c => c.String());
            AlterColumn("dbo.Kafedras", "Kafedra_zav", c => c.String());
            AlterColumn("dbo.Kafedras", "Kafedra_name", c => c.String());
            AlterColumn("dbo.Instytyts", "Director", c => c.String());
            AlterColumn("dbo.Instytyts", "Instytyts_name", c => c.String());
            DropTable("dbo.InterStudents");
        }
    }
}
