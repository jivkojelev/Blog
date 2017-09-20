namespace Blog.DbContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserRolesAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "isAdmin", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "isAdmin");
        }
    }
}
