using DomainClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMngt.SQLDB
{
    public class SchoolMngtDBContext :DbContext
    {
        public SchoolMngtDBContext()
        {
            //Database.Connection.ConnectionString=
        }
        public SchoolMngtDBContext(string conn):base(conn)
        {
            //Database.Connection.ConnectionString = conn;
            //Database.SetInitializer(new SchoolMngtContextInitializer());
            //Database.SetInitializer<SchoolMngtDBContext>(new DropCreateDatabaseIfModelChanges<SchoolMngtDBContext>());

        }
        //public DbSet<AdminMaster> tblAdminMaster{ get; set; }
        //public DbSet<FacultyMaster> tblFacultyMaster { get; set; }
        //public DbSet<StudentMaster> tblStudentMaster { get; set; }
        public DbSet<AttendanceMaster> tblAttendanceMaster { get; set; }
        public DbSet<BatchMaster> tblBatchMaster { get; set; }
        public DbSet<CorrectOptionMaster> tblCorrectOptionMaster { get; set; }
        public DbSet<CourseMaster> tblCourseMaster { get; set; }
        public DbSet<GlobalNoteMaster> tblGlobalNoteMaster { get; set; }
        public DbSet<OnlineExamMaster> tblOnlineExamMaster { get; set; }
        public DbSet<QuestionMaster> tblQuestionMaster { get; set; }
        public DbSet<OptionsMaster> tblOptionsMaster { get; set; }
        public DbSet<ResearchMaster> tblResearchMaster { get; set; }
        public DbSet<ResultMaster> tblResultMaster { get; set; }
        public DbSet<SuggestionMaster> tblSuggestionMaster { get; set; }
        public DbSet<StudentMaster> tblStudentMaster { get; set; }
        public DbSet<UserMaster> tblUserMaster { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Database.SetInitializer(new SchoolMngtContextInitializer());
                        
            //smodelBuilder.Entity<UserMaster>().HasIndex(u => u.Username).IsUnique();
            base.OnModelCreating(modelBuilder);
        }
    }
}
