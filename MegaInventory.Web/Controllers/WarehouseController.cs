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
    public class WarehouseController : BaseController
    {
        public WarehouseController(IStoreService storeService, IConfiguration configuration ) : base(storeService, configuration)
        {

        }
        public IActionResult Index()
        {
            return View("Create");
        }

        [HttpPost]
        public async Task<IActionResult> Create(WareHouseViewModel model)
        {
            if (ModelState.IsValid)
            {
                var warehouse = new WarehouseDTO
                {
                    Warehouse = new BLL.Entities.Warehouse
                    {
                        InventoryLocationAbbreviation = model.Abbreviation,
                        InventoryLocationAddress = model.Address,
                        InventoryLocationName = model.Name
                    }
                };
                var request = Request<WarehouseDTO>.CreateRequest(warehouse,ApiKey, Operation.Insert.ToString());
                var result = await _storeService.AddOrUpdateWarehouse(request);
                if (result.IsSuccess)
                {
                    RedirectToAction("Index", "Home");
                }
                return View();
            }
            return View();
        }
    }
}
