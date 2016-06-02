namespace BoxService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeSurvey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUsers", "surveyId", "dbo.Surveys");
            DropIndex("dbo.AspNetUsers", new[] { "surveyId" });
            CreateTable(
                "dbo.Boxes",
                c => new
                    {
                        BoxID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.BoxID);
            
            AddColumn("dbo.AspNetUsers", "BoxId", c => c.Int(nullable: false));
            CreateIndex("dbo.AspNetUsers", "BoxId");
            AddForeignKey("dbo.AspNetUsers", "BoxId", "dbo.Boxes", "BoxID", cascadeDelete: true);
            DropColumn("dbo.Surveys", "Question3");
            DropColumn("dbo.Surveys", "Question4");
            DropColumn("dbo.AspNetUsers", "surveyId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "surveyId", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Question4", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Question3", c => c.Int(nullable: false));
            DropForeignKey("dbo.AspNetUsers", "BoxId", "dbo.Boxes");
            DropIndex("dbo.AspNetUsers", new[] { "BoxId" });
            DropColumn("dbo.AspNetUsers", "BoxId");
            DropTable("dbo.Boxes");
            CreateIndex("dbo.AspNetUsers", "surveyId");
            AddForeignKey("dbo.AspNetUsers", "surveyId", "dbo.Surveys", "SurveyID", cascadeDelete: true);
        }
    }
}
