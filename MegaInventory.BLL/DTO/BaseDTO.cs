using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MegaInventory.BLL.DTO
{
    public abstract class BaseDTO
    {
        [JsonProperty("ResponseStatus")]
        public ResponseStatus ResponseStatus { get; set; }
        [JsonProperty("entityID")]
        public string EntityId { get; set; }
    }
    public class ResponseStatus
    {
        [JsonProperty("ErrorCode")]
        public string ErrorCode { get; set; }

    }
}
