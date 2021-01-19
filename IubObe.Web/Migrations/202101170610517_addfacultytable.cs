namespace IubObe.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addfacultytable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        FacultyId = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 250),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.FacultyId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Faculties");
        }
    }
}
