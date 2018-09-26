using System;

namespace RetailPro.Backend.Areas.UserSpace.Models.Posts
{
    public class PostDto : PublishPostDto
    {
        public Guid Id { get; set; }

        public PublicProfileDto Author { get; set; }
        public long CreateTimestamp { get; set; }
        public long LastUpdateTimestamp { get; set; }

        public Uri PostCommentsUri { get; set; }
        public Uri ConversationUri { get; set; }
    }
}
