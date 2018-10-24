using System;

namespace RetailPro.Backend.Areas.UserSpace.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Handle { get; set; }
        public string AvatarUrl { get; set; }
        public string Biography { get; set; }
        public string PublicEmailAddress { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public Address ShippingAddress { get; set; }
        public Address BillingAddress { get; set; }
    }
}
