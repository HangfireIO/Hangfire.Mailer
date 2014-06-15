using HangFire.SqlServer;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(HangFire.Mailer.Startup))]

namespace HangFire.Mailer
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseHangFire(config =>
            {
                config.UseSqlServerStorage("MailerDb");
                config.UseServer();
            });
        }
    }
}
