namespace BoxService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class boxid : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUsers", "BoxId", "dbo.Boxes");
            DropIndex("dbo.AspNetUsers", new[] { "BoxId" });
            AlterColumn("dbo.AspNetUsers", "BoxId", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "BoxId");
            AddForeignKey("dbo.AspNetUsers", "BoxId", "dbo.Boxes", "BoxID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "BoxId", "dbo.Boxes");
            DropIndex("dbo.AspNetUsers", new[] { "BoxId" });
            AlterColumn("dbo.AspNetUsers", "BoxId", c => c.Int(nullable: false));
            CreateIndex("dbo.AspNetUsers", "BoxId");
            AddForeignKey("dbo.AspNetUsers", "BoxId", "dbo.Boxes", "BoxID", cascadeDelete: true);
        }
    }
}
