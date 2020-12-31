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
    public class SalesOrderController : BaseController
    {
        public SalesOrderController(IStoreService storeService, IConfiguration configuration) : base(storeService, configuration)
        {

        }
        public IActionResult Index()
        {
            return View("Create");
        }

        [HttpPost]
        public async Task<IActionResult> Create(SalesOrderViewModel model)
        {
            if (ModelState.IsValid)
            {
                var warehouse = new SalesOrderDTO
                {
                    SalesOrder = new BLL.Entities.SalesOrder
                    {
                        SalesOrderInventoryLocationID =1,
                        SalesOrderClientId = model.ClientId,
                        SalesOrderStatus = "Verified",
                        SalesOrderDetails = new List<BLL.Entities.SalesOrderDetail>
                        {
                            new BLL.Entities.SalesOrderDetail
                            {
                                 SalesOrderRowProductSku = model.ProductSku,
                                 SalesOrderRowUnitPriceWithoutTaxOrDiscount = model.GrossPrice,
                                 SalesOrderRowQuantity = model.Quantity,
                                 SalesOrderRowShippedQuantity =0,
                                 SalesOrderRowTotalAmount = model.NetPrice,
                                 SalesOrderRowTotalDiscountAmount = model.DiscountAmount,
                                 SalesOrderTotalTaxAmount = model.TaxAmount
                            }
                        }


                    }
                };
                var request = Request<SalesOrderDTO>.CreateRequest(warehouse, ApiKey, Operation.Insert.ToString());
                var result = await _storeService.AddSalesOrder(request);
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
