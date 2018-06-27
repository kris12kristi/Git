namespace Laba5_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new_colm : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.InterStudents", "Students_surname", c => c.String(maxLength: 25));
        }
        
        public override void Down()
        {
            DropColumn("dbo.InterStudents", "Students_surname");
        }
    }
}
