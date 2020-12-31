using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MegaInventory.BLL.Entities
{
    public class Warehouse
    {
        [JsonProperty("InventoryLocationName")]
        public string InventoryLocationName { get; set; }

        [JsonProperty("InventoryLocationAbbreviation")]
        public string InventoryLocationAbbreviation { get; set; }

        [JsonProperty("InventoryLocationAddress")]
        public string InventoryLocationAddress { get; set; }

    }
}