using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullContactDotNet.Entities
{
    public class Organization
    {
        public bool IsPrimary { get; set; }
        public string Name { get; set; }
        public string StartDate { get; set; }
        public string Title { get; set; }
        public bool Current { get; set; }
    }
}
