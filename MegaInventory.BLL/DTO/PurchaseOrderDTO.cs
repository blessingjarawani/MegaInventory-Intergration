using MegaInventory.BLL.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MegaInventory.BLL.DTO
{
   public class PurchaseOrderDTO: BaseDTO
    {
        [JsonProperty("mvPurchaseOrder")]
        public PurchaseOrder PurchaseOrder { get; set; }
    }
}
