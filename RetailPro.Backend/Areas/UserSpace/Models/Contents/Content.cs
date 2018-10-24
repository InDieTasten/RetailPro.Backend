using System;
using System.Collections.Generic;

namespace RetailPro.Backend.Areas.UserSpace.Models.Contents
{
    public class Content
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ContentType ContentType{ get; set; }

        public User Author { get; set; }

        public Tile Tile { get; set; }

        public ICollection<ContentModule> ContentModules { get; set; }
    }
}
