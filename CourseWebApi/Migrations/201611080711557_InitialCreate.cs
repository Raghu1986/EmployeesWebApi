namespace CourseWebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        AutoId = c.Int(nullable: false, identity: true),
                        CourseType = c.String(),
                        SubCourse = c.String(),
                    })
                .PrimaryKey(t => t.AutoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Courses");
        }
    }
}
