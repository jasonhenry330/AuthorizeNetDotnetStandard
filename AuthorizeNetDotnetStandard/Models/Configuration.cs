using System;
using System.Collections.Generic;
using System.Text;

namespace AuthorizeNetDotnetStandard.Models
{
    public class Configuration
    {
        public string URL { get; set; }
        public string LoginId { get; set; }
        public string TransactionKey { get; set; }
        public string ValidationMode { get; set; }
        public string RegionPrefix { get; set; }
    }
}
