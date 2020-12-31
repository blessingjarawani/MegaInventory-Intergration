using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MegaInventory.BLL.Entities
{
    public class Product
    {
        [JsonProperty("ProductID")]
        public long ProductId { get; set; }

        [JsonProperty("ProductType")]
        public string ProductType { get; set; }

        [JsonProperty("ProductSKU")]
        public string ProductSku { get; set; }

        [JsonProperty("ProductEAN")]
        public string ProductEan { get; set; }

        [JsonProperty("ProductDescription")]
        public string ProductDescription { get; set; }

        [JsonProperty("ProductVersion")]
        public string ProductVersion { get; set; }

        [JsonProperty("ProductLongDescription")]
        public string ProductLongDescription { get; set; }

        [JsonProperty("ProductCategoryID")]
        public long ProductCategoryId { get; set; }

        [JsonProperty("ProductUnitOfMeasurement")]
        public string ProductUnitOfMeasurement { get; set; }

        [JsonProperty("ProductSellingPrice")]
        public double ProductSellingPrice { get; set; }

        [JsonProperty("ProductPurchasePrice")]
        public double ProductPurchasePrice { get; set; }

        [JsonProperty("ProductUnitCost")]
        public long ProductUnitCost { get; set; }

        [JsonProperty("ProductWeight")]
        public long ProductWeight { get; set; }

        [JsonProperty("ProductLength")]
        public long ProductLength { get; set; }

        [JsonProperty("ProductBreadth")]
        public long ProductBreadth { get; set; }

        [JsonProperty("ProductHeight")]
        public long ProductHeight { get; set; }

        [JsonProperty("ProductImageURL")]
        public string ProductImageUrl { get; set; }

        [JsonProperty("ProductComments")]
        public string ProductComments { get; set; }

        [JsonProperty("ProductCustomField1")]
        public string ProductCustomField1 { get; set; }

        [JsonProperty("ProductCustomField2")]
        public string ProductCustomField2 { get; set; }

        [JsonProperty("ProductCustomField3")]
        public string ProductCustomField3 { get; set; }

        [JsonProperty("ProductCustomField4")]
        public string ProductCustomField4 { get; set; }

        [JsonProperty("ProductCustomField5")]
        public string ProductCustomField5 { get; set; }

        [JsonProperty("ProductCustomField6")]
        public string ProductCustomField6 { get; set; }

        [JsonProperty("ProductCustomField7")]
        public string ProductCustomField7 { get; set; }

        [JsonProperty("ProductCustomField8")]
        public string ProductCustomField8 { get; set; }

        [JsonProperty("ProductCustomField9")]
        public string ProductCustomField9 { get; set; }

        [JsonProperty("ProductCustomField10")]
        public string ProductCustomField10 { get; set; }

        [JsonProperty("ProductMainSupplierID")]
        public long ProductMainSupplierId { get; set; }

        [JsonProperty("ProductMainSupplierPrice")]
        public long ProductMainSupplierPrice { get; set; }

        [JsonProperty("ProductMainSupplierSKU")]
        public string ProductMainSupplierSku { get; set; }

        [JsonProperty("ProductMainSupplierDescription")]
        public string ProductMainSupplierDescription { get; set; }

        [JsonProperty("ProductCreationDate")]
        public string ProductCreationDate { get; set; }

        [JsonProperty("ProductOption1")]
        public bool ProductOption1 { get; set; }

        [JsonProperty("ProductOption2")]
        public bool ProductOption2 { get; set; }

        [JsonProperty("ProductOption3")]
        public bool ProductOption3 { get; set; }

        [JsonProperty("ProductOption4")]
        public bool ProductOption4 { get; set; }

        [JsonProperty("ProductOption5")]
        public bool ProductOption5 { get; set; }

        [JsonProperty("IsInventorySerialised")]
        public bool IsInventorySerialised { get; set; }

        [JsonProperty("IsBatchNumbersEnabled")]
        public bool IsBatchNumbersEnabled { get; set; }
    }
}
