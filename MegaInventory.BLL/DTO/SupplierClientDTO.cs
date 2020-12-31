using MegaInventory.BLL.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MegaInventory.BLL.DTO
{
    public class SupplierClientDTO : BaseDTO
    {
        [JsonProperty("mvSupplierClient")]
        public SupplierClient SupplierClient;
    }
}
