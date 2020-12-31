using MegaInventory.ShopService.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaInventory.Web.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IStoreService _storeService;
        protected readonly string ApiKey;
        public BaseController(IStoreService storeService, IConfiguration configuration)
        {
            ApiKey = configuration.GetSection("ApiKey").Value;
            _storeService = storeService;
        }
    }
}
