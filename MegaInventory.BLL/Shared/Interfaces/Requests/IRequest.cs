using System;
using System.Collections.Generic;
using System.Text;

namespace MegaInventory.BLL.Shared.Interfaces.Requests
{
    public interface IRequest<T> : IBaseRequest
    {
        T Object { get; }
        string  MvRecordAction { get; }
    }
}
