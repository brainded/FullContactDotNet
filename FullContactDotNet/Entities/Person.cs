using System.Collections.Generic;

namespace FullContactDotNet.Entities
{
    public class Person
    {
        public int Status { get; set; }
        public string RequestId { get; set; }
        public double Likelihood { get; set; }
        public List<Photo> Photos { get; set; }
        public ContactInfo ContactInfo { get; set; }
        public List<Organization> Organizations { get; set; }
        public Demographics Demographics { get; set; }
        public List<SocialProfile> SocialProfiles { get; set; }
        public DigitalFootprint DigitalFootprint { get; set; }
    }
}
