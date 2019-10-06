namespace WebRuby.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Projects", "Deadline", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Tasks", "Deadline", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tasks", "Deadline", c => c.String());
            AlterColumn("dbo.Projects", "Deadline", c => c.String());
        }
    }
}
