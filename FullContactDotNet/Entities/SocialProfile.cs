
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullContactDotNet.Entities
{
    public class SocialProfile
    {
        public string Bio { get; set; }
        public string Type { get; set; }
        public string TypeId { get; set; }
        public string TypeName { get; set; }
        public string Url { get; set; }
        public string Id { get; set; }
        public string Username { get; set; }
        public int? Followers { get; set; }
        public int? Following { get; set; }
    }
}
