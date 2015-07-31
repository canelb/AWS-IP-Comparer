using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace IP_Range.Model
{
    class AWSIPRange
    { 
        public string SyncToken { get; set; }
        public string CreateDate { get; set; }
        public List<Prefix> Prefixes { get; set; }
    }
}
