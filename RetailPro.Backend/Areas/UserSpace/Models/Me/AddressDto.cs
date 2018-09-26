using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailPro.Backend.Areas.UserSpace.Models.Me
{
    public class AddressDto
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Additional1 { get; set; }
        public string Additional2 { get; set; }
    }
}
