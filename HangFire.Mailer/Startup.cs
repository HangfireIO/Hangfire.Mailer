using Hangfire.SqlServer;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Hangfire.Mailer.Startup))]

namespace Hangfire.Mailer
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseHangfire(config =>
            {
                config.UseFilter(new LogFailureAttribute());
                config.UseSqlServerStorage("MailerDb");
                config.UseServer();
            });
        }
    }
}
