using SchoolMngt.SQLDB;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace CodeFirstMVCSchoolMngt
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Database.SetInitializer(new SchoolMngtContextInitializer());

            string constr = ConfigurationManager.ConnectionStrings["CodeFirstSchoolMngtConnString"].ToString();
            var dbcon = new SchoolMngtDBContext(constr);

            //using (var dbcon = new SchoolMngtDBContext(constr))
            //{
            //    DomainClasses.UserMaster admin = new DomainClasses.UserMaster();
            //    admin.Username = "admin";
            //    admin.Password = "password";
            //    dbcon.tblUserMaster.Add(admin);

            //    dbcon.SaveChanges();
            //}
        }
    }
}