using DomainClasses;
using SchoolMngt.SQLDB;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstMVCSchoolMngt.Controllers
{
    public class AccountsController : Controller
    {
        //
        // GET: /Accounts/
        SchoolMngtDBContext context = new SchoolMngtDBContext();
        [HttpGet]
        public ActionResult Login()
        {
            var login = context.tblUserMaster.Select(u => u.Username).FirstOrDefault();
            return View(new UserMaster());
        }
        [HttpPost]
        public ActionResult Login(UserMaster model)
        {
            if (ModelState.IsValid)
            {
                string uname = model.Username;

                string pass = model.Password;
                using (var dbcon = new SchoolMngtDBContext(ConfigurationManager.ConnectionStrings["CodeFirstSchoolMngtConnString"].ToString()))
                {
                    
                    var query = (from s in dbcon.tblUserMaster
                                 where s.Username.Equals(uname) && s.Password == pass
                                 select s).ToList();

                }
            }

            return View();
        }



    }
}
