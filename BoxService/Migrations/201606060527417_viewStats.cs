namespace BoxService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class viewStats : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NumberOfAccounts = c.Int(),
                        MonthlyTotal = c.Double(),
                        PercentTerribleBeers = c.Double(),
                        PercentWonderfulBeers = c.Double(),
                        PercentTerribleWines = c.Double(),
                        PercentWonderfulWines = c.Double(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Admins");
        }
    }
}
