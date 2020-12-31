using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MegaInventory.BLL.Entities
{
    public class SalesOrderDetail
    {
        [JsonProperty("SalesOrderRowDetailID")]
        public long SalesOrderRowDetailId { get; set; }

        [JsonProperty("SalesOrderRowProductID")]
        public long SalesOrderRowProductId { get; set; }

        [JsonProperty("SalesOrderRowProductSKU")]
        public string SalesOrderRowProductSku { get; set; }

        [JsonProperty("SalesOrderRowQuantity")]
        public long SalesOrderRowQuantity { get; set; }

        [JsonProperty("SalesOrderRowShippedQuantity")]
        public long SalesOrderRowShippedQuantity { get; set; }

        [JsonProperty("SalesOrderRowInvoicedQuantity")]
        public long SalesOrderRowInvoicedQuantity { get; set; }

        [JsonProperty("SalesOrderRowUnitPriceWithoutTaxOrDiscount")]
        public double SalesOrderRowUnitPriceWithoutTaxOrDiscount { get; set; }

        [JsonProperty("SalesOrderRowTaxID")]
        public long SalesOrderRowTaxId { get; set; }

        [JsonProperty("SalesOrderTotalTaxAmount")]
        public long SalesOrderTotalTaxAmount { get; set; }

        [JsonProperty("SalesOrderRowDiscountID")]
        public long SalesOrderRowDiscountId { get; set; }

        [JsonProperty("SalesOrderRowTotalDiscountAmount")]
        public long SalesOrderRowTotalDiscountAmount { get; set; }

        [JsonProperty("SalesOrderRowTotalAmount")]
        public double SalesOrderRowTotalAmount { get; set; }

        [JsonProperty("SalesOrderRowRemarks")]
        public string SalesOrderRowRemarks { get; set; }
    }
}
