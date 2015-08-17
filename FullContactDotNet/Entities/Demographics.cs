using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullContactDotNet.Entities
{
    public class Demographics
    {
        public LocationDeduced LocationDeduced { get; set; }
        public string Gender { get; set; }
        public string LocationGeneral { get; set; }
    }
}
