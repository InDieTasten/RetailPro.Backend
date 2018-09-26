using System;

namespace RetailPro.Backend.Areas.UserSpace.Models.Contents
{
    public class TileDto
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }

        public int Likes { get; set; }
        public int Shares { get; set; }
        public int Comments { get; set; }

        public Uri TileLargeUri { get; set; }
        public Uri TileMediumUri { get; set; }
        public Uri TileSmallUri { get; set; }

        public Uri IconUri { get; set; }
    }
}
