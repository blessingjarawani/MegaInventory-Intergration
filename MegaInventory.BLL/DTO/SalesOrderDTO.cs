using MegaInventory.BLL.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MegaInventory.BLL.DTO
{
    public class SalesOrderDTO : BaseDTO
    {
        [JsonProperty("mvSalesOrder")]
        public SalesOrder SalesOrder { get; set; }
    }
}
