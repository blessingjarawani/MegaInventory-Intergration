using System;
using System.Collections.Generic;
using System.Text;

namespace MegaInventory.BLL.Shared.Interfaces.Responses
{
    public interface IResponse<T> : IBaseResponse
    {
        T Result { get; }
    }
}
