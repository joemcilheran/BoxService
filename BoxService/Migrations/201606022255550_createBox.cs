namespace BoxService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createBox : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "BoxPrice", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "BoxPrice");
        }
    }
}
