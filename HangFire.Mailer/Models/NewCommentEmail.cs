using Postal;

namespace HangFire.Mailer.Models
{
    public class NewCommentEmail : Email
    {
        public string To { get; set; }
        public string UserName { get; set; }
        public string Comment { get; set; }
    }
}