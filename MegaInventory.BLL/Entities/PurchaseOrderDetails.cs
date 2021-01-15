using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MegaInventory.BLL.Entities
{
    public class PurchaseOrderDetails
    {
        [JsonProperty("PurchaseOrderRowProductSKU")]
        public string PurchaseOrderRowProductSKU { get; set; }
        [JsonProperty("PurchaseOrderRowQuantity")]
        public string PurchaseOrderRowQuantity { get; set; }
        [JsonProperty("PurchaseOrderRowReceivedQuantity")]
        public string PurchaseOrderRowReceivedQuantity { get; set; }
        [JsonProperty("PurchaseOrderRowInvoicedQuantity")]
        public string PurchaseOrderRowInvoicedQuantity { get; set; }
        [JsonProperty("PurchaseOrderRowUnitPriceWithoutTaxOrDiscount")]
        public string PurchaseOrderRowUnitPriceWithoutTaxOrDiscount { get; set; }
    }
}
