using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MegaInventory.BLL.Entities
{
    public class SalesOrder
    {

        [JsonProperty("SalesOrderClientID")]
        public string SalesOrderClientId { get; set; }

        [JsonProperty("SalesOrderDetails")]
        public List<SalesOrderDetail> SalesOrderDetails { get; set; }

        [JsonProperty("SalesOrderStatus")]
        public string SalesOrderStatus { get; set; }
        [JsonProperty("SalesOrderInventoryLocationID")]
        public long SalesOrderInventoryLocationID { get; set; }



    }
}
