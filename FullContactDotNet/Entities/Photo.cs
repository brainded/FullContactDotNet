using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullContactDotNet.Entities
{
    public class Photo
    {
        public string Type { get; set; }
        public string TypeId { get; set; }
        public string TypeName { get; set; }
        public string Url { get; set; }
        public bool IsPrimary { get; set; }
    }
}
