using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MegaInventory.BLL.Entities
{
    public class SalesOrder
    {
        [JsonProperty("SalesOrderId")]
        public long SalesOrderId { get; set; }

        [JsonProperty("SalesOrderTypeId")]
        public long SalesOrderTypeId { get; set; }

        [JsonProperty("SalesOrderTypeAbbreviation")]
        public string SalesOrderTypeAbbreviation { get; set; }

        [JsonProperty("SalesOrderTypeDescription")]
        public string SalesOrderTypeDescription { get; set; }

        [JsonProperty("SalesOrderNo")]
        public string SalesOrderNo { get; set; }

        [JsonProperty("SalesOrderReferenceNo")]
        public string SalesOrderReferenceNo { get; set; }

        [JsonProperty("SalesOrderReferenceApplication")]
        public string SalesOrderReferenceApplication { get; set; }

        [JsonProperty("SalesOrderDate")]
        public string SalesOrderDate { get; set; }

        [JsonProperty("SalesOrderCustomOrderDate1")]
        public string SalesOrderCustomOrderDate1 { get; set; }

        [JsonProperty("SalesOrderCustomOrderDate2")]
        public string SalesOrderCustomOrderDate2 { get; set; }

        [JsonProperty("SalesOrderCurrencyCode")]
        public string SalesOrderCurrencyCode { get; set; }

        [JsonProperty("SalesOrderClientID")]
        public string SalesOrderClientId { get; set; }

        [JsonProperty("SalesOrderBillingAddress")]
        public string SalesOrderBillingAddress { get; set; }

        [JsonProperty("SalesOrderShippingAddress")]
        public string SalesOrderShippingAddress { get; set; }

        [JsonProperty("SalesOrderContactPerson")]
        public string SalesOrderContactPerson { get; set; }

        [JsonProperty("SalesOrderInventoryLocationID")]
        public long SalesOrderInventoryLocationId { get; set; }

        [JsonProperty("SalesOrderCustomFlag1")]
        public string SalesOrderCustomFlag1 { get; set; }

        [JsonProperty("SalesOrderCustomFlag2")]
        public string SalesOrderCustomFlag2 { get; set; }

        [JsonProperty("SalesOrderCustomFlag3")]
        public bool SalesOrderCustomFlag3 { get; set; }

        [JsonProperty("SalesOrderCustomFlag4")]
        public bool SalesOrderCustomFlag4 { get; set; }

        [JsonProperty("SalesOrderCustomFlag5")]
        public bool SalesOrderCustomFlag5 { get; set; }

        [JsonProperty("SalesOrderCustomFlag6")]
        public bool SalesOrderCustomFlag6 { get; set; }

        [JsonProperty("SalesOrderCustomFlag7")]
        public bool SalesOrderCustomFlag7 { get; set; }

        [JsonProperty("SalesOrderCustomFlag8")]
        public bool SalesOrderCustomFlag8 { get; set; }

        [JsonProperty("SalesOrderCustomFlag9")]
        public bool SalesOrderCustomFlag9 { get; set; }

        [JsonProperty("SalesOrderCustomFlag10")]
        public bool SalesOrderCustomFlag10 { get; set; }

        [JsonProperty("SalesOrderComments")]
        public string SalesOrderComments { get; set; }

        [JsonProperty("SalesOrderTags")]
        public string SalesOrderTags { get; set; }

        [JsonProperty("SalesOrderPaymentTermsEnumeration")]
        public string SalesOrderPaymentTermsEnumeration { get; set; }

        [JsonProperty("SalesOrderTotalQuantity")]
        public long SalesOrderTotalQuantity { get; set; }

        [JsonProperty("SalesOrderAmountSubtotalWithoutTaxAndDiscount")]
        public double SalesOrderAmountSubtotalWithoutTaxAndDiscount { get; set; }

        [JsonProperty("SalesOrderAmountShipping")]
        public long SalesOrderAmountShipping { get; set; }

        [JsonProperty("SalesOrderAmountTotalDiscount")]
        public long SalesOrderAmountTotalDiscount { get; set; }

        [JsonProperty("SalesOrderAmountTotalTax")]
        public long SalesOrderAmountTotalTax { get; set; }

        [JsonProperty("SalesOrderAmountGrandTotal")]
        public double SalesOrderAmountGrandTotal { get; set; }

        [JsonProperty("SalesOrderDetails")]
        public SalesOrderDetail[] SalesOrderDetails { get; set; }

        [JsonProperty("SalesOrderStatus")]
        public string SalesOrderStatus { get; set; }

        [JsonProperty("SalesOrderCreationDate")]
        public string SalesOrderCreationDate { get; set; }

        [JsonProperty("SalesOrderLastUpdatedDate")]
        public string SalesOrderLastUpdatedDate { get; set; }
    }
}
