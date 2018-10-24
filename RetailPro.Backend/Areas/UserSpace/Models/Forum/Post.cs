using System;
using System.Collections.Generic;

namespace RetailPro.Backend.Areas.UserSpace.Models.Forum
{
    public class Post
    {
        public Guid Id { get; set; }
        public User Author { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        ICollection<Comment> Comments { get; set; }
    }
}
