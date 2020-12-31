using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MegaInventory.BLL.Shared.Interfaces.Requests
{
    public interface IRequest<T>
    {
        T Object { get; }
        string MvRecordAction { get; }
        string ApiKey { get; }
    }
}
