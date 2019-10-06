namespace WebRuby.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Projects", "Status");
            DropColumn("dbo.Tasks", "Deadline");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tasks", "Deadline", c => c.DateTime(nullable: false));
            AddColumn("dbo.Projects", "Status", c => c.Boolean(nullable: false));
        }
    }
}
