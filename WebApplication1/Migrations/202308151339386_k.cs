namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class k : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        rollno = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 10),
                        age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.rollno);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        staffId = c.Int(nullable: false, identity: true),
                        staffName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.staffId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
        }
    }
}
