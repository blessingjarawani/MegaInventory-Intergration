using MegaInventory.BLL.DTO;
using MegaInventory.BLL.Shared.Interfaces;
using MegaInventory.BLL.Shared.Interfaces.Requests;
using MegaInventory.BLL.Shared.Interfaces.Responses;
using MegaInventory.BLL.Shared.Responses;
using MegaInventory.DAL.Repositories;
using MegaInventory.ShopService.Services.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace MegaInventory.ShopService.Services
{
    public class StoreService : IStoreService
    {
        public IMegaInventoryRepository _megaInventoryRepository;
        public StoreService(IConfiguration configuration)
        {
            var baseUrl = configuration.GetSection("BaseApiUrl").Value;
            _megaInventoryRepository = new MegaInventoryRepository(baseUrl);
        }

        public async Task<IResponse<WarehouseDTO>> AddOrUpdateWarehouse(IRequest<WarehouseDTO> request)
        {
            try
            {
                if (request == null)
                {
                    return Response<WarehouseDTO>.CreateFail("Invalid Request");
                }

                var result = await _megaInventoryRepository.AddWareHouse(request);
                if (result != null && result?.ResponseStatus?.ErrorCode == "0")
                {
                    return Response<WarehouseDTO>.CreateSuccess(result);
                }
                return Response<WarehouseDTO>.CreateFail("Error On Saving Warehouses");
            }
            catch (Exception ex)
            {
                return Response<WarehouseDTO>.CreateFail(ex.Message);
            }
        }

        public async Task<IResponse<SupplierClientDTO>> AddorUpdateClient(IRequest<SupplierClientDTO> request)
        {
            try
            {
                if (request == null)
                {
                    return Response<SupplierClientDTO>.CreateFail("Invalid Request");
                }

                var result = await _megaInventoryRepository.AddClient(request);
                if (result != null && result?.ResponseStatus?.ErrorCode == "0")
                {
                    return Response<SupplierClientDTO>.CreateSuccess(result);
                }
                return Response<SupplierClientDTO>.CreateFail("Error On Saving Client");
            }
            catch (Exception ex)
            {
                return Response<SupplierClientDTO>.CreateFail(ex.Message);
            }
        }

        public async Task<IResponse<ProductDTO>> AddProduct(IRequest<ProductDTO> request)
        {
            try
            {
                if (request == null)
                {
                    return Response<ProductDTO>.CreateFail("Invalid Request");
                }

                var result = await _megaInventoryRepository.AddProduct(request);
                if (result != null && result?.ResponseStatus?.ErrorCode == "0")
                {
                    return Response<ProductDTO>.CreateSuccess(result);
                }
                return Response<ProductDTO>.CreateFail("Error On Saving Product");
            }
            catch (Exception ex)
            {
                return Response<ProductDTO>.CreateFail(ex.Message);
            }
        }

        public async Task<IResponse<SalesOrderDTO>> AddSalesOrder(IRequest<SalesOrderDTO> request)
        {
            try
            {
                if (request == null)
                {
                    return Response<SalesOrderDTO>.CreateFail("Invalid Request");
                }
                var result = await _megaInventoryRepository.AddSalesOrder(request);
                if (result != null && result?.ResponseStatus?.ErrorCode == "0")
                {
                    return Response<SalesOrderDTO>.CreateSuccess(result);
                }
                return Response<SalesOrderDTO>.CreateFail("Error On Saving Client");
            }
            catch (Exception ex)
            {
                return Response<SalesOrderDTO>.CreateFail(ex.Message);
            }
        }

          public async Task<IResponse<PurchaseOrderDTO>> UpdatePurchasesOrder(IRequest<PurchaseOrderDTO> request)
        {
            try
            {
                if (request == null)
                {
                    return Response<PurchaseOrderDTO>.CreateFail("Invalid Request");
                }
                var result = await _megaInventoryRepository.UpdatePurchaseOrder(request);
                if (result != null && result?.ResponseStatus?.ErrorCode == "0")
                {
                    return Response<PurchaseOrderDTO>.CreateSuccess(result);
                }
                return Response<PurchaseOrderDTO>.CreateFail("Error On Saving Client");
            }
            catch (Exception ex)
            {
                return Response<PurchaseOrderDTO>.CreateFail(ex.Message);
            }
        }
    }
}
