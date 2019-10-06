namespace WebRuby.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "Deadline", c => c.String());
            AddColumn("dbo.Tasks", "Deadline", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "Deadline");
            DropColumn("dbo.Projects", "Deadline");
        }
    }
}
