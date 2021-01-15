using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MegaInventory.BLL.Entities
{
    public class PurchaseOrder
    {
        [JsonProperty("PurchaseOrderSupplierId")]
        public long PurchaseOrderSupplierId { get; set; }

        [JsonProperty("PurchaseOrderTypeId")]
        public long PurchaseOrderTypeId { get; set; }

        [JsonProperty("PurchaseOrderInventoryLocationID")]

        public long PurchaseOrderInventoryLocationID { get; set; }

        [JsonProperty("PurchaseOrderStatus")]

        public long PurchaseOrderStatus { get; set; }

        [JsonProperty("PurchaseOrderNo")]
        public long PurchaseOrderNo { get; set; }

        [JsonProperty("PurchaseOrderDetails")]
        public List<PurchaseOrderDetails> PurchaseOrderDetails { get; set; }

    }
}
