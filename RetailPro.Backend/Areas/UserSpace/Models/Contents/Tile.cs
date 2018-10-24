using System;

namespace RetailPro.Backend.Areas.UserSpace.Models.Contents
{
    public class Tile
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }

        public long ViewCount { get; set; }
        public long LikeCount { get; set; }
        public long CommentCount { get; set; }
        public long ShareCount { get; set; }

        public string TileLargeUrl { get; set; }
        public string TileMediumUrl { get; set; }
        public string TileSmallUrl { get; set; }
    }
}
