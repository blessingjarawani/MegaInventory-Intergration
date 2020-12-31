using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MegaInventory.BLL.Entities
{
    public class Contact
    {
        [JsonProperty("ContactName")]
        public string ContactName { get; set; }

        [JsonProperty("ContactDepartment")]
        public string ContactDepartment { get; set; }

        [JsonProperty("ContactEmail", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactEmail { get; set; }

        [JsonProperty("ContactIsPrimary")]
        public bool ContactIsPrimary { get; set; }
    }
}
