using MegaInventory.BLL.DTO;
using MegaInventory.BLL.Shared.Interfaces.Requests;
using MegaInventory.BLL.Shared.Interfaces.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MegaInventory.ShopService.Services.Interface
{
    public interface IStoreService
    {
        Task<IResponse<WarehouseDTO>> AddOrUpdateWarehouse(IRequest<WarehouseDTO> request);
        Task<IResponse<SupplierClientDTO>> AddorUpdateClient(IRequest<SupplierClientDTO> request);
        Task<IResponse<ProductDTO>> AddProduct(IRequest<ProductDTO> request);
        Task<IResponse<SalesOrderDTO>> AddSalesOrder(IRequest<SalesOrderDTO> request);
        Task<IResponse<PurchaseOrderDTO>> UpdatePurchasesOrder(IRequest<PurchaseOrderDTO> request);
    }
}
