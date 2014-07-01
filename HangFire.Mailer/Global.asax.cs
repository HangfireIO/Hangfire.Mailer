using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Routing;
using HangFire.Mailer.Controllers;
using HangFire.Mailer.Migrations;
using HangFire.Mailer.Models;

namespace HangFire.Mailer
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MailerDbContext, Configuration>());
        }
    }
}
