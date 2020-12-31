using MegaInventory.BLL.Shared.Interfaces.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace MegaInventory.BLL.Shared.Requests
{
    public class ObjectRequest<T> : BaseRequest, IRequest<T>
    {
        public T Object { get; }
        public string MvRecordAction { get; }

        private ObjectRequest(T request, string mvRecordAction = null)
        {
            Object = request;
            MvRecordAction = mvRecordAction;
        }
        public static ObjectRequest<T> CreateRequest(T request, string mvRecordAction = null) => new ObjectRequest<T>(request, mvRecordAction);
    }


}
