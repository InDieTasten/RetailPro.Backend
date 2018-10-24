using System;

namespace RetailPro.Backend.Areas.UserSpace.Models.Forum
{
    public class Comment
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public Post Post { get; set; }
        public User Author { get; set; }
        public string Body { get; set; }
    }
}
