using MegaInventory.BLL.Shared.Interfaces.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace MegaInventory.BLL.Shared.Requests
{
    public abstract class BaseRequest : IBaseRequest
    {
        public string ApiKey { get; } = "9ddcbc41876c3f1b@m103546";
    }
}
