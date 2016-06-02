namespace BoxService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedSurvey : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Surveys",
                c => new
                    {
                        SurveyID = c.Int(nullable: false, identity: true),
                        Question1 = c.Int(nullable: false),
                        Question2 = c.Int(nullable: false),
                        Question3 = c.Int(nullable: false),
                        Question4 = c.Int(nullable: false),
                        UserID = c.String(),
                    })
                .PrimaryKey(t => t.SurveyID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Surveys");
        }
    }
}
