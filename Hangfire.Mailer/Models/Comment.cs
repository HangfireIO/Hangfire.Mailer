using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Hangfire.Mailer.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Username")]
        public string UserName { get; set; }

        [Required, AllowHtml]
        public string Text { get; set; }
    }
}