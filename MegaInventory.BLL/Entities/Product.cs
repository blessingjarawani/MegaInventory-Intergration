using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MegaInventory.BLL.Entities
{
    public class Product
    {

        [JsonProperty("ProductDescription")]
        public string ProductDescription { get; set; }

        [JsonProperty("ProductSellingPrice")]
        public double ProductSellingPrice { get; set; }

        [JsonProperty("ProductPurchasePrice")]
        public double ProductPurchasePrice { get; set; }


        [JsonProperty("ProductSKU")]
        public string ProductSKU { get; set; }


    }
}
