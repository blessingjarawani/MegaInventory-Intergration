using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MegaInventory.BLL.Entities
{
    public class SupplierClient
    {
        [JsonProperty("SupplierClientID")]
        public string SupplierClientId { get; set; }

        [JsonProperty("SupplierClientType")]
        public string SupplierClientType { get; set; }

        [JsonProperty("SupplierClientName")]
        public string SupplierClientName { get; set; }

        [JsonProperty("mvContacts")]
        public Contact[] Contacts { get; set; }

        [JsonProperty("SupplierClientBillingAddress")]
        public string SupplierClientBillingAddress { get; set; }

        [JsonProperty("SupplierClientShippingAddress1")]
        public string SupplierClientShippingAddress1 { get; set; }

        [JsonProperty("SupplierClientShippingAddress2")]
        public string SupplierClientShippingAddress2 { get; set; }

        [JsonProperty("SupplierClientPhone1")]
        public string SupplierClientPhone1 { get; set; }

        [JsonProperty("SupplierClientPhone2")]
        public string SupplierClientPhone2 { get; set; }

        [JsonProperty("SupplierClientFax")]
        public string SupplierClientFax { get; set; }

        [JsonProperty("SupplierClientIM")]
        public string SupplierClientIm { get; set; }

        [JsonProperty("SupplierClientEmail")]
        public string SupplierClientEmail { get; set; }

        [JsonProperty("SupplierClientTaxID")]
        public string SupplierClientTaxId { get; set; }

        [JsonProperty("SupplierClientComments")]
        public string SupplierClientComments { get; set; }

        [JsonProperty("SupplierClientCustomField1")]
        public string SupplierClientCustomField1 { get; set; }

        [JsonProperty("SupplierClientCustomField2")]
        public string SupplierClientCustomField2 { get; set; }

        [JsonProperty("SupplierClientCustomField3")]
        public string SupplierClientCustomField3 { get; set; }

        [JsonProperty("SupplierClientCustomField4")]
        public string SupplierClientCustomField4 { get; set; }

        [JsonProperty("SupplierClientCustomField5")]
        public string SupplierClientCustomField5 { get; set; }

        [JsonProperty("SupplierClientOption1")]
        public string SupplierClientOption1 { get; set; }

        [JsonProperty("SupplierClientOption2")]
        public string SupplierClientOption2 { get; set; }

        [JsonProperty("SupplierClientOption3")]
        public string SupplierClientOption3 { get; set; }

        [JsonProperty("SupplierClientOption4")]
        public string SupplierClientOption4 { get; set; }

        [JsonProperty("SupplierClientOption5")]
        public string SupplierClientOption5 { get; set; }

        [JsonProperty("SupplierClientCreationDate")]
        public string SupplierClientCreationDate { get; set; }
    }
}
