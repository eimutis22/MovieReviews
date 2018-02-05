namespace MovieReview.Migrations.MovieMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movie",
                c => new
                    {
                        ImdbID = c.Int(nullable: false, identity: true),
                        Title = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ImdbID);
            
            CreateTable(
                "dbo.Review",
                c => new
                    {
                        ReviewId = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        ImdbId = c.Int(nullable: false),
                        ReviewComment = c.String(),
                        DateCreated = c.DateTime(storeType: "date"),
                        StarRating = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReviewId)
                .ForeignKey("dbo.User", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FirstName = c.Int(nullable: false),
                        LastName = c.Int(nullable: false),
                        DOB = c.Int(nullable: false),
                        Email = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Review", "UserID", "dbo.User");
            DropIndex("dbo.Review", new[] { "UserID" });
            DropTable("dbo.User");
            DropTable("dbo.Review");
            DropTable("dbo.Movie");
        }
    }
}
