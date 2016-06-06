namespace BoxService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class anotherOne : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "BoxName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "BoxName");
        }
    }
}
