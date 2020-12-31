using MegaInventory.BLL.Shared.Interfaces.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace MegaInventory.BLL.Shared.Requests
{
    public class Request<T> : IRequest<T>
    {
        public T Object { get; }
        public string MvRecordAction { get; }

        public string ApiKey { get; }
        private Request(T request, string apiKey, string mvRecordAction = null)
        {
            Object = request;
            MvRecordAction = mvRecordAction;
            ApiKey = apiKey;
        }
        public static Request<T> CreateRequest(T request, string apiKey, string mvRecordAction = null) => new Request<T>(request, apiKey, mvRecordAction);
    }


}
