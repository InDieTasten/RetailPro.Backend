using RetailPro.Backend.Models;
using System;

namespace RetailPro.Backend.Areas.UserSpace.Models
{
    public class PublicProfileDto : BaseDto
    {
        public string Handle { get; set; }
        public string AvatarUrl { get; set; }
        public string Biography { get; set; }
        public string PublicEmailAddress { get; set; }

        public Uri BadgesUrl { get; set; }
        public Uri PostCommentsUri { get; set; }
        public Uri PostsUri { get; set; }
    }
}
