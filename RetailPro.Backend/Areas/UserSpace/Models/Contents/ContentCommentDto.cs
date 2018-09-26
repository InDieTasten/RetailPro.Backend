using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailPro.Backend.Areas.UserSpace.Models.Contents
{
    public class ContentCommentDto : PublishContentCommentDto
    {
        public int Likes { get; set; }

        public PublicProfileDto Author { get; set; }
        public long CreateTimestamp { get; set; }
        public long LastUpdateTimestamp { get; set; }

        public Uri ContentUri { get; set; }
    }
}
