using System.ComponentModel.DataAnnotations;

namespace ElWaheb.Api.Entites
{
    public class Notification : Base
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime SentAt { get; set; }
        public bool IsRead { get; set; }

        public User User { get; set; }
        public string UserId { get; set; }

    }
}
