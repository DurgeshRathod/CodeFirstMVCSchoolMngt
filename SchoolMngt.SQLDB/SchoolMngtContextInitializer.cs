using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SchoolMngt.SQLDB
{
    public class SchoolMngtContextInitializer : DropCreateDatabaseIfModelChanges<SchoolMngtDBContext>
    {

        protected override void Seed(SchoolMngtDBContext dbcon)
        {

            DomainClasses.UserMaster admin = new DomainClasses.UserMaster();
            admin.Username = "admin";
            admin.Password = "password";
            dbcon.tblUserMaster.Add(admin);

            base.Seed(dbcon);
        }
    }
}
