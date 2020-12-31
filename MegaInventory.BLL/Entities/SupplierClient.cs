using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MegaInventory.BLL.Entities
{
    public class SupplierClient
    {

        [JsonProperty("SupplierClientType")]
        public string SupplierClientType { get; set; }

        [JsonProperty("SupplierClientName")]
        public string SupplierClientName { get; set; }

        [JsonProperty("SupplierClientBillingAddress")]
        public string SupplierClientBillingAddress { get; set; }

        [JsonProperty("SupplierClientPhone1")]
        public string SupplierClientPhone1 { get; set; }

        [JsonProperty("SupplierClientEmail")]
        public string SupplierClientEmail { get; set; }
       
    }
}
