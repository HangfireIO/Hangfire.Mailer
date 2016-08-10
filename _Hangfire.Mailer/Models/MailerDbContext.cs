using System.Data.Entity;

namespace Hangfire.Mailer.Models
{
    public class MailerDbContext : DbContext
    {
        public MailerDbContext()
            : base("MailerDb")
        {
        }

        public DbSet<Comment> Comments { get; set; }
    }
}