using SchoolMngt.SQLDB;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstMVCSchoolMngt.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            /*string constr = ConfigurationManager.ConnectionStrings["CodeFirstSchoolMngtConnString"].ToString();
            DomainClasses.StudentMaster stud = new DomainClasses.StudentMaster();
            stud.City = "Aurangabad";
            using( var dbcon = new SchoolMngtDBContext(constr))
            {
                
                dbcon.tblStudentMaster.Add(stud);
                dbcon.SaveChanges();
            }
            */
            return View();
        }

        [HttpGet]
        public ActionResult login()
        {

            return View();
        }

    }
}
