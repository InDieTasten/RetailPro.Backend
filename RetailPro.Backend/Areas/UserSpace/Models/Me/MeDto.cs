using System;

namespace RetailPro.Backend.Areas.UserSpace.Models.Me
{
    public class MeDto : PublicProfileDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public AddressDto ShippingAddress { get; set; }
        public AddressDto BillingAddress { get; set; }

        public Uri LikedContentsUri { get; set; }
        public Uri LikedPostsUri { get; set; }
        public Uri LikedPostCommentsUri { get; set; }
        public Uri CompletedContentsUri { get; set; }
        public Uri TransactionsUri { get; set; }
    }
}
