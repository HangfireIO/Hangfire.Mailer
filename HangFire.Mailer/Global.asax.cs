using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Routing;
using Hangfire.Mailer.Migrations;
using Hangfire.Mailer.Models;

namespace Hangfire.Mailer
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
