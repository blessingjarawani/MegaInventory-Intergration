using System;
using System.Collections.Generic;
using System.Text;

namespace MegaInventory.BLL.Shared.Interfaces.Responses
{
    public interface IBaseResponse
    {
        bool IsSuccess { get; }
        string Message { get; }
    }
}
