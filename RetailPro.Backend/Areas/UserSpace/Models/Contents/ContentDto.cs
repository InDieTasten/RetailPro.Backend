using System;

namespace RetailPro.Backend.Areas.UserSpace.Models.Contents
{
    public class ContentDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ContentType { get; set; }

        public PublicProfileDto Author { get; set; }
        public long CreateTimeStamp { get; set; }
        public long LastUpdateTimestamp { get; set; }

        public TileDto Tile { get; set; } = new TileDto();

        public Uri[] ContentModuleUris { get; set; }
    }
}
