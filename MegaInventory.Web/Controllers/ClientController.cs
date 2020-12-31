using MegaInventory.BLL.DTO;
using MegaInventory.BLL.Shared.Requests;
using MegaInventory.ShopService.Services.Interface;
using MegaInventory.Web.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MegaInventory.BLL.Shared.Dictionaries;

namespace MegaInventory.Web.Controllers
{
    public class ClientController : BaseController
    {
        public ClientController(IStoreService storeService, IConfiguration configuration) : base(storeService, configuration)
        {

        }
        public IActionResult Index()
        {
            return View("Create");
        }

        [HttpPost]
        public async Task<IActionResult> Create(ClientViewModel model)
        {
            if (ModelState.IsValid)
            {
                var client = new SupplierClientDTO
                {
                    SupplierClient = new BLL.Entities.SupplierClient
                    {
                        SupplierClientBillingAddress = model.ShippingAddress,
                        SupplierClientEmail = model.Email,
                        SupplierClientName = model.Name,
                        SupplierClientPhone1 = model.Phone,
                        SupplierClientType = "Client"
                    }
                };
                var request = Request<SupplierClientDTO>.CreateRequest(client, ApiKey, Operation.Insert.ToString());
                var result = await _storeService.AddorUpdateClient(request);
                if (result.IsSuccess)
                {
                    return RedirectToAction("Index", "Home");
                }
                return View();
            }
            return View();
        }
    }
}
