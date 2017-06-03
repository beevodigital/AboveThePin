namespace AboveThePin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialTableStub : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PhoneNumber = c.String(),
                        Par = c.Int(nullable: false),
                        NumberOfHoles = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Rounds",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        NumberOfHoles = c.Int(nullable: false),
                        Course_ID = c.Int(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Courses", t => t.Course_ID)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.Course_ID)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rounds", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Rounds", "Course_ID", "dbo.Courses");
            DropIndex("dbo.Rounds", new[] { "User_Id" });
            DropIndex("dbo.Rounds", new[] { "Course_ID" });
            DropTable("dbo.Rounds");
            DropTable("dbo.Courses");
        }
    }
}
