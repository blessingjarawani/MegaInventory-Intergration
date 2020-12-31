using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MegaInventory.BLL.Entities
{
    public class Warehouse
    {
        [JsonProperty("InventoryLocationID")]
        public string InventoryLocationId { get; set; }

        [JsonProperty("InventoryLocationName")]
        public string InventoryLocationName { get; set; }

        [JsonProperty("InventoryLocationAbbreviation")]
        public string InventoryLocationAbbreviation { get; set; }

        [JsonProperty("InventoryLocationAddress")]
        public string InventoryLocationAddress { get; set; }

        [JsonProperty("InventoryLocationCurrencyCode")]
        public string InventoryLocationCurrencyCode { get; set; }
    }
}