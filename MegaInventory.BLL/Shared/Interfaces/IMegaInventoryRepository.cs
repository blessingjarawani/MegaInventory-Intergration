using MegaInventory.BLL.DTO;
using MegaInventory.BLL.Entities;
using MegaInventory.BLL.Shared.Interfaces.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MegaInventory.BLL.Shared.Interfaces
{
    public interface IMegaInventoryRepository
    {
        Task<SupplierClientDTO> AddorUpdateClient(IRequest<Product> objectRequest);
        Task<WarehouseDTO> AddOrUpdateWareHouse(IRequest<Warehouse> objectRequest);
        Task<ProductDTO> AddOrUpdateProduct(IRequest<Product> objectRequest);
        Task<SalesOrderDTO> AddSalesOrder(IRequest<SalesOrderDTO> objectRequest);
    }
}