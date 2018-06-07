namespace SchoolMngt.SQLDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateFirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AttendanceMasters",
                c => new
                    {
                        AttendanceId = c.Int(nullable: false, identity: true),
                        LectureDate = c.DateTime(),
                        attendance = c.String(),
                        topic = c.String(),
                    })
                .PrimaryKey(t => t.AttendanceId);
            
            CreateTable(
                "dbo.BatchMasters",
                c => new
                    {
                        BatchId = c.Int(nullable: false, identity: true),
                        BatchName = c.String(),
                        Batch_totalStud = c.Int(nullable: false),
                        BatchStart = c.DateTime(),
                        BatchEnd = c.DateTime(),
                        BatchDuration = c.String(),
                        BatchProgress = c.String(),
                        BatchDays = c.String(),
                        BatchStatus = c.String(),
                    })
                .PrimaryKey(t => t.BatchId);
            
            CreateTable(
                "dbo.CorrectOptionMasters",
                c => new
                    {
                        CorrectOptionId = c.Int(nullable: false, identity: true),
                        QuestionId = c.Int(nullable: false),
                        OptionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CorrectOptionId);
            
            CreateTable(
                "dbo.CourseMasters",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        CourseName = c.String(),
                        BatchName = c.String(),
                        StudentStatus = c.String(),
                        LectureStatus = c.String(),
                        FacultyName = c.String(),
                        BatchId_BatchId = c.Int(),
                        UserCode_UserCode = c.Int(),
                    })
                .PrimaryKey(t => t.CourseId)
                .ForeignKey("dbo.BatchMasters", t => t.BatchId_BatchId)
                .ForeignKey("dbo.UserMasters", t => t.UserCode_UserCode)
                .Index(t => t.BatchId_BatchId)
                .Index(t => t.UserCode_UserCode);
            
            CreateTable(
                "dbo.UserMasters",
                c => new
                    {
                        UserCode = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Fname = c.String(),
                        Lanme = c.String(),
                        Gender = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Email = c.String(),
                        Qualification = c.String(),
                        Course = c.Int(nullable: false),
                        JoiningDate = c.DateTime(),
                        MobileNo = c.Long(nullable: false),
                        phoneNo = c.Long(nullable: false),
                        Status = c.String(),
                        isActive = c.String(),
                        RememberMe = c.Boolean(nullable: false),
                        UserGroupId_UserGroupid = c.Int(),
                    })
                .PrimaryKey(t => t.UserCode)
                .ForeignKey("dbo.UserGroups", t => t.UserGroupId_UserGroupid)
                .Index(t => t.UserGroupId_UserGroupid);
            
            CreateTable(
                "dbo.UserGroups",
                c => new
                    {
                        UserGroupid = c.Int(nullable: false, identity: true),
                        GroupName = c.String(),
                    })
                .PrimaryKey(t => t.UserGroupid);
            
            CreateTable(
                "dbo.GlobalNoteMasters",
                c => new
                    {
                        GlobalNoteId = c.Int(nullable: false, identity: true),
                        Note = c.String(),
                        Date = c.DateTime(),
                    })
                .PrimaryKey(t => t.GlobalNoteId);
            
            CreateTable(
                "dbo.OnlineExamMasters",
                c => new
                    {
                        ExamId = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        PaperId = c.Int(nullable: false),
                        ExamDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ExamId);
            
            CreateTable(
                "dbo.OptionsMasters",
                c => new
                    {
                        OptionnId = c.Int(nullable: false, identity: true),
                        Option = c.String(),
                        QuestionId_QuestionId = c.Int(),
                    })
                .PrimaryKey(t => t.OptionnId)
                .ForeignKey("dbo.QuestionMasters", t => t.QuestionId_QuestionId)
                .Index(t => t.QuestionId_QuestionId);
            
            CreateTable(
                "dbo.QuestionMasters",
                c => new
                    {
                        QuestionId = c.Int(nullable: false, identity: true),
                        Questions = c.String(),
                        PaperId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.QuestionId);
            
            CreateTable(
                "dbo.ResearchMasters",
                c => new
                    {
                        ResearchId = c.Int(nullable: false, identity: true),
                        FacultyId = c.Int(nullable: false),
                        Research = c.String(),
                    })
                .PrimaryKey(t => t.ResearchId);
            
            CreateTable(
                "dbo.ResultMasters",
                c => new
                    {
                        ResultId = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        ExamDate = c.DateTime(),
                        Obt_marks = c.Int(nullable: false),
                        Total_marks = c.Int(nullable: false),
                        Attendance = c.String(),
                        Course = c.String(),
                        Batch = c.String(),
                    })
                .PrimaryKey(t => t.ResultId);
            
            CreateTable(
                "dbo.StudentMasters",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Fname = c.String(),
                        Lanme = c.String(),
                        Gender = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Email = c.String(),
                        Qualification = c.String(),
                        Course = c.Int(nullable: false),
                        JoiningDate = c.DateTime(),
                        MobileNo = c.Long(nullable: false),
                        phoneNo = c.Long(nullable: false),
                        Username = c.String(),
                        Password = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.StudentId);
            
            CreateTable(
                "dbo.SuggestionMasters",
                c => new
                    {
                        SuggestionId = c.Int(nullable: false, identity: true),
                        Suggestion = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SuggestionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OptionsMasters", "QuestionId_QuestionId", "dbo.QuestionMasters");
            DropForeignKey("dbo.CourseMasters", "UserCode_UserCode", "dbo.UserMasters");
            DropForeignKey("dbo.UserMasters", "UserGroupId_UserGroupid", "dbo.UserGroups");
            DropForeignKey("dbo.CourseMasters", "BatchId_BatchId", "dbo.BatchMasters");
            DropIndex("dbo.OptionsMasters", new[] { "QuestionId_QuestionId" });
            DropIndex("dbo.UserMasters", new[] { "UserGroupId_UserGroupid" });
            DropIndex("dbo.CourseMasters", new[] { "UserCode_UserCode" });
            DropIndex("dbo.CourseMasters", new[] { "BatchId_BatchId" });
            DropTable("dbo.SuggestionMasters");
            DropTable("dbo.StudentMasters");
            DropTable("dbo.ResultMasters");
            DropTable("dbo.ResearchMasters");
            DropTable("dbo.QuestionMasters");
            DropTable("dbo.OptionsMasters");
            DropTable("dbo.OnlineExamMasters");
            DropTable("dbo.GlobalNoteMasters");
            DropTable("dbo.UserGroups");
            DropTable("dbo.UserMasters");
            DropTable("dbo.CourseMasters");
            DropTable("dbo.CorrectOptionMasters");
            DropTable("dbo.BatchMasters");
            DropTable("dbo.AttendanceMasters");
        }
    }
}
