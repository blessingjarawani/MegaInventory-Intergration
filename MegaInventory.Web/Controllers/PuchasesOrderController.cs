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
    public class PuchasesOrderController : BaseController
    {
        public PuchasesOrderController(IStoreService storeService, IConfiguration configuration) : base(storeService, configuration)
        {

        }
        public IActionResult Index()
        {
            return View("Create");
        }
        [HttpPost]
        public async Task<IActionResult> Create(PurcahsesOrderViewModel model)
        {
            if (ModelState.IsValid)
            {
                var warehouse = new PurchaseOrderDTO
                {
                    PurchaseOrder = new BLL.Entities.PurchaseOrder
                    {
                        PurchaseOrderNo = model.PurchaseOrderNo,
                        PurchaseOrderInventoryLocationID = model.PurchaseOrderInventoryLocationID,
                        PurchaseOrderStatus = model.PurchaseOrderStatus,
                        PurchaseOrderSupplierId = model.PurchaseOrderSupplierId,
                        PurchaseOrderTypeId = model.PurchaseOrderTypeId,
                        PurchaseOrderDetails = new List<BLL.Entities.PurchaseOrderDetails>
                        {
                            new BLL.Entities.PurchaseOrderDetails
                            {
                                  PurchaseOrderRowInvoicedQuantity = model.PurchaseOrderRowInvoicedQuantity,
                                  PurchaseOrderRowProductSKU = model.PurchaseOrderRowProductSKU,
                                   PurchaseOrderRowQuantity = model.PurchaseOrderRowQuantity,
                                   PurchaseOrderRowReceivedQuantity = model.PurchaseOrderRowReceivedQuantity,
                                    PurchaseOrderRowUnitPriceWithoutTaxOrDiscount = model.PurchaseOrderRowUnitPriceWithoutTaxOrDiscount
                            }
                        }


                    }
                };
                var request = Request<PurchaseOrderDTO>.CreateRequest(warehouse, ApiKey, Operation.Insert.ToString());
                var result = await _storeService.UpdatePurchasesOrder(request);
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
