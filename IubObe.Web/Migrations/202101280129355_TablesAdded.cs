namespace IubObe.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablesAdded : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Students");
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        OMark = c.Single(nullable: false),
                        FMark = c.Single(nullable: false),
                        QuestionId = c.String(maxLength: 128),
                        EnrollId = c.String(maxLength: 128),
                        FacultyId = c.String(maxLength: 128),
                        CreatedOn = c.DateTime(),
                        ModifiedOn = c.DateTime(),
                        CreatedBy = c.String(),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Enrolls", t => t.EnrollId)
                .ForeignKey("dbo.Questions", t => t.QuestionId)
                .ForeignKey("dbo.Facults", t => t.FacultyId)
                .Index(t => t.QuestionId)
                .Index(t => t.EnrollId)
                .Index(t => t.FacultyId);
            
            CreateTable(
                "dbo.Enrolls",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        SectionId = c.String(maxLength: 128),
                        StudentId = c.String(maxLength: 128),
                        CreatedOn = c.DateTime(),
                        ModifiedOn = c.DateTime(),
                        CreatedBy = c.String(),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sections", t => t.SectionId)
                .ForeignKey("dbo.Students", t => t.StudentId)
                .Index(t => t.SectionId)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        SectionNo = c.Int(nullable: false),
                        Semester = c.String(),
                        Year = c.DateTime(nullable: false),
                        CourseId = c.String(maxLength: 128),
                        FacultyId = c.String(maxLength: 128),
                        CreatedOn = c.DateTime(),
                        ModifiedOn = c.DateTime(),
                        CreatedBy = c.String(),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Facults", t => t.FacultyId)
                .ForeignKey("dbo.Courses", t => t.CourseId)
                .Index(t => t.CourseId)
                .Index(t => t.FacultyId);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        ProgramId = c.String(nullable: false, maxLength: 128),
                        CreatedOn = c.DateTime(),
                        ModifiedOn = c.DateTime(),
                        CreatedBy = c.String(),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Programs", t => t.ProgramId, cascadeDelete: true)
                .Index(t => t.ProgramId);
            
            CreateTable(
                "dbo.COes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        OMark = c.Single(nullable: false),
                        FMark = c.Single(nullable: false),
                        PloId = c.String(nullable: false, maxLength: 128),
                        CourseId = c.String(nullable: false, maxLength: 128),
                        CreatedOn = c.DateTime(),
                        ModifiedOn = c.DateTime(),
                        CreatedBy = c.String(),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.PLOes", t => t.PloId, cascadeDelete: true)
                .Index(t => t.PloId)
                .Index(t => t.CourseId);
            
            CreateTable(
                "dbo.PLOes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        PlNo = c.Int(nullable: false),
                        OMark = c.Single(nullable: false),
                        FMark = c.Single(nullable: false),
                        ProgramId = c.String(nullable: false, maxLength: 128),
                        CreatedOn = c.DateTime(),
                        ModifiedOn = c.DateTime(),
                        CreatedBy = c.String(),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Programs", t => t.ProgramId, cascadeDelete: true)
                .Index(t => t.ProgramId);
            
            CreateTable(
                "dbo.Programs",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        CreatedOn = c.DateTime(),
                        ModifiedOn = c.DateTime(),
                        CreatedBy = c.String(),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        QuestionName = c.String(),
                        OMark = c.Single(nullable: false),
                        FMark = c.Single(nullable: false),
                        SectionId = c.String(maxLength: 128),
                        FacultyId = c.String(maxLength: 128),
                        CoId = c.String(maxLength: 128),
                        CreatedOn = c.DateTime(),
                        ModifiedOn = c.DateTime(),
                        CreatedBy = c.String(),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.COes", t => t.CoId)
                .ForeignKey("dbo.Facults", t => t.FacultyId)
                .ForeignKey("dbo.Sections", t => t.SectionId)
                .Index(t => t.SectionId)
                .Index(t => t.FacultyId)
                .Index(t => t.CoId);
            
            CreateTable(
                "dbo.Facults",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Gender = c.String(),
                        Dob = c.DateTime(nullable: false),
                        Email = c.String(),
                        CreatedOn = c.DateTime(),
                        ModifiedOn = c.DateTime(),
                        CreatedBy = c.String(),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Students", "Id", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Students", "Gender", c => c.String());
            AddColumn("dbo.Students", "Dob", c => c.DateTime(nullable: false));
            AddColumn("dbo.Students", "CreatedOn", c => c.DateTime());
            AddColumn("dbo.Students", "ModifiedOn", c => c.DateTime());
            AddColumn("dbo.Students", "CreatedBy", c => c.String());
            AddColumn("dbo.Students", "ModifiedBy", c => c.String());
            AlterColumn("dbo.Students", "Name", c => c.String());
            AlterColumn("dbo.Students", "Email", c => c.String());
            AddPrimaryKey("dbo.Students", "Id");
            DropColumn("dbo.Students", "StudentId");
            DropColumn("dbo.Students", "CourseId");
            DropColumn("dbo.Students", "Section");
            DropColumn("dbo.Students", "Semester");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Semester", c => c.String(nullable: false));
            AddColumn("dbo.Students", "Section", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "CourseId", c => c.String(nullable: false));
            AddColumn("dbo.Students", "StudentId", c => c.String(nullable: false, maxLength: 128));
            DropForeignKey("dbo.Enrolls", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Enrolls", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.Sections", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Questions", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.Sections", "FacultyId", "dbo.Facults");
            DropForeignKey("dbo.Questions", "FacultyId", "dbo.Facults");
            DropForeignKey("dbo.Answers", "FacultyId", "dbo.Facults");
            DropForeignKey("dbo.Questions", "CoId", "dbo.COes");
            DropForeignKey("dbo.Answers", "QuestionId", "dbo.Questions");
            DropForeignKey("dbo.PLOes", "ProgramId", "dbo.Programs");
            DropForeignKey("dbo.Courses", "ProgramId", "dbo.Programs");
            DropForeignKey("dbo.COes", "PloId", "dbo.PLOes");
            DropForeignKey("dbo.COes", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Answers", "EnrollId", "dbo.Enrolls");
            DropIndex("dbo.Questions", new[] { "CoId" });
            DropIndex("dbo.Questions", new[] { "FacultyId" });
            DropIndex("dbo.Questions", new[] { "SectionId" });
            DropIndex("dbo.PLOes", new[] { "ProgramId" });
            DropIndex("dbo.COes", new[] { "CourseId" });
            DropIndex("dbo.COes", new[] { "PloId" });
            DropIndex("dbo.Courses", new[] { "ProgramId" });
            DropIndex("dbo.Sections", new[] { "FacultyId" });
            DropIndex("dbo.Sections", new[] { "CourseId" });
            DropIndex("dbo.Enrolls", new[] { "StudentId" });
            DropIndex("dbo.Enrolls", new[] { "SectionId" });
            DropIndex("dbo.Answers", new[] { "FacultyId" });
            DropIndex("dbo.Answers", new[] { "EnrollId" });
            DropIndex("dbo.Answers", new[] { "QuestionId" });
            DropPrimaryKey("dbo.Students");
            AlterColumn("dbo.Students", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Students", "ModifiedBy");
            DropColumn("dbo.Students", "CreatedBy");
            DropColumn("dbo.Students", "ModifiedOn");
            DropColumn("dbo.Students", "CreatedOn");
            DropColumn("dbo.Students", "Dob");
            DropColumn("dbo.Students", "Gender");
            DropColumn("dbo.Students", "Id");
            DropTable("dbo.Facults");
            DropTable("dbo.Questions");
            DropTable("dbo.Programs");
            DropTable("dbo.PLOes");
            DropTable("dbo.COes");
            DropTable("dbo.Courses");
            DropTable("dbo.Sections");
            DropTable("dbo.Enrolls");
            DropTable("dbo.Answers");
            AddPrimaryKey("dbo.Students", "StudentId");
        }
    }
}
