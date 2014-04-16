using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace HangFire.Mailer.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required, AllowHtml]
        public string Text { get; set; }
    }
}