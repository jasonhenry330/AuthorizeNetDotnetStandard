using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthorizeNetDotnetStandard.Models
{
    public class Order
    {
		[JsonProperty(PropertyName = "invoiceNumber")]
        public string InvoiceNumber { get; set; }
    }
}
