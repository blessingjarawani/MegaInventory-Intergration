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
    public class ProductController : BaseController
    {
        public ProductController(IStoreService storeService, IConfiguration configuration) : base(storeService, configuration)
        {

        }
        public IActionResult Index()
        {
            return View("Create");
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                var product = new ProductDTO
                {
                    Product = new BLL.Entities.Product
                    {
                        ProductDescription = model.Description,
                        ProductSKU = model.SKU,
                        ProductPurchasePrice = model.PurchasePrice,
                        ProductSellingPrice = model.SalePrice
                    }
                };
                var request = Request<ProductDTO>.CreateRequest(product, ApiKey, Operation.Insert.ToString());
                var result = await _storeService.AddProduct(request);
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
