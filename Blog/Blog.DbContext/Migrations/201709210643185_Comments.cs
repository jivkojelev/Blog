namespace Blog.DbContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Comments : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Posts", "Comments_ID", c => c.String(maxLength: 128));
            //DropIndex("dbo.Comments", new[] { "Post_ID" });
            //RenameColumn(table: "dbo.Comments", name: "Post_ID", newName: "Comments_ID");
            //CreateIndex("dbo.Posts", "Comments_ID");
        }

        public override void Down()
        {
            //DropIndex("dbo.Posts", new[] { "Comments_ID" });
            //RenameColumn(table: "dbo.Comments", name: "Comments_ID", newName: "Post_ID");
            //CreateIndex("dbo.Comments", "Post_ID");
            //DropColumn("dbo.Posts", "Comments_ID");
        }
    }
}
