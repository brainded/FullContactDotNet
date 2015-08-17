using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullContactDotNet.Entities
{
    public class ContactInfo
    {
        public List<Chat> Chats { get; set; }
        public List<Website> Websites { get; set; }
        public string FamilyName { get; set; }
        public string FullName { get; set; }
        public string GivenName { get; set; }
    }
}
