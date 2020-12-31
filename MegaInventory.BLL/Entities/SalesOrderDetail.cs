using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MegaInventory.BLL.Entities
{
    public class SalesOrderDetail
    {

        [JsonProperty("SalesOrderRowProductSKU")]
        public string SalesOrderRowProductSku { get; set; }

        [JsonProperty("SalesOrderRowQuantity")]
        public long SalesOrderRowQuantity { get; set; }

        [JsonProperty("SalesOrderRowShippedQuantity")]
        public long SalesOrderRowShippedQuantity { get; set; }

        [JsonProperty("SalesOrderRowTotalDiscountAmount")]
        public decimal SalesOrderRowTotalDiscountAmount { get; set; }

        [JsonProperty("SalesOrderRowTotalAmount")]
        public decimal SalesOrderRowTotalAmount { get; set; }
        
        [JsonProperty("SalesOrderTotalTaxAmount")]
        public decimal SalesOrderTotalTaxAmount { get; set; }
        [JsonProperty("SalesOrderRowUnitPriceWithoutTaxOrDiscount")]
        public decimal SalesOrderRowUnitPriceWithoutTaxOrDiscount { get; set; }

    }
}
