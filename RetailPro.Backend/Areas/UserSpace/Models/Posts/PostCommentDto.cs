using RetailPro.Backend.Areas.UserSpace.Models.Posts;
using RetailPro.Backend.Models;
using System;

namespace RetailPro.Backend.Areas.UserSpace.Models.Posts
{
    public class PostCommentDto : PublishPostCommentDto
    {
        public int Likes { get; set; }

        public PublicProfileDto Author { get; set; }
        public long CreateTimestamp { get; set; }
        public long LastUpdateTimestamp { get; set; }

        public Uri PostUri { get; set; }
    }
}
