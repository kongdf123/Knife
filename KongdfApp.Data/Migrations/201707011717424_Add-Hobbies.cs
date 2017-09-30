namespace Knife.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHobbies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Resumes", "Hobbies", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Resumes", "Hobbies");
        }
    }
}
