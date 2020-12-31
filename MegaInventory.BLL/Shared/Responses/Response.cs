﻿using MegaInventory.BLL.Shared.Interfaces.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MegaInventory.BLL.Shared.Responses
{
    public class Response<T> : BaseResponse, IResponse<T>
    {
        public T Result { get; }
        public Response()
        {

        }
        private Response(T result, bool isSuccess, string message = null) : base(isSuccess, message)
        {
            Result = result;
        }
        private Response(bool isSuccess, string message = null) : base(isSuccess, message)
        {
        }
        public static Response<T> CreateSuccess(T result) => new Response<T>(result, true);
        public static Response<T> CreateFail(string message) => new Response<T>(false, message);
    }
}
