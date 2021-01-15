using MegaInventory.BLL.DTO;
using MegaInventory.BLL.Entities;
using MegaInventory.BLL.Shared.Interfaces;
using MegaInventory.BLL.Shared.Interfaces.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MegaInventory.DAL.Repositories
{
    public class MegaInventoryRepository : IMegaInventoryRepository
    {
        private string _httpBaseUrl;
        private HttpClient _httpClient;
        public MegaInventoryRepository(string httpBaseUrl)
        {
            _httpBaseUrl = httpBaseUrl;
            _httpClient = InitHttpClient();
        }

        private HttpClient InitHttpClient()
        {
            if (_httpClient != null)
                return _httpClient;
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(_httpBaseUrl);
            httpClient.Timeout = new TimeSpan(0, 0, 5, 0);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return httpClient;
        }


        public async Task<WarehouseDTO> AddWareHouse(IRequest<WarehouseDTO> objectRequest)
        {
            try
            {
                if (objectRequest == null)
                    return null;
                var json = JsonConvert.SerializeObject(
                    new
                    {
                        objectRequest.ApiKey,
                        mvInventoryLocation =
                    new
                    {
                        objectRequest.Object.Warehouse.InventoryLocationAbbreviation,
                        objectRequest.Object.Warehouse.InventoryLocationAddress,
                        objectRequest.Object.Warehouse.InventoryLocationName
                    },
                        objectRequest.MvRecordAction
                    });

                var response = await _httpClient.PostAsync("InventoryLocation/InventoryLocationUpdate?", ReturnStringContent(json));
                if (!response.IsSuccessStatusCode)
                    return null;
                var result = JsonConvert.DeserializeObject<WarehouseDTO>(response.Content.ReadAsStringAsync().Result);
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetBaseException().Message);
                return null;
            }

        }

        private StringContent ReturnStringContent(string json)
        {
            return new StringContent(json, Encoding.UTF8, "application/json");
        }

        public async Task<ProductDTO> AddProduct(IRequest<ProductDTO> objectRequest)
        {
            try
            {
                if (objectRequest == null)
                    return null;
                var json = JsonConvert.SerializeObject(new
                {
                    objectRequest.ApiKey,
                    mvProduct = new
                    {
                        objectRequest.Object.Product.ProductDescription,
                        objectRequest.Object.Product.ProductPurchasePrice,
                        objectRequest.Object.Product.ProductSellingPrice,
                        objectRequest.Object.Product.ProductSKU
                    }
                    ,
                    objectRequest.MvRecordAction
                });
                var response = await _httpClient.PostAsync("Product/ProductUpdate?", ReturnStringContent(json));
                if (!response.IsSuccessStatusCode)
                    return null;
                var result = JsonConvert.DeserializeObject<ProductDTO>(response.Content.ReadAsStringAsync().Result);
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetBaseException().Message);
                return null;
            }

        }

        public async Task<SupplierClientDTO> AddClient(IRequest<SupplierClientDTO> objectRequest)
        {
            try
            {
                if (objectRequest == null)
                    return null;
                var json = JsonConvert.SerializeObject(new
                {
                    objectRequest.ApiKey,
                    mvSupplierClient = new
                    {
                        objectRequest.Object.SupplierClient.SupplierClientBillingAddress,
                        objectRequest.Object.SupplierClient.SupplierClientEmail,
                        objectRequest.Object.SupplierClient.SupplierClientName,
                        objectRequest.Object.SupplierClient.SupplierClientPhone1,
                        objectRequest.Object.SupplierClient.SupplierClientType
                    },
                    objectRequest.MvRecordAction
                });
                var response = await _httpClient.PostAsync("SupplierClient/SupplierClientUpdate?", ReturnStringContent(json));
                if (!response.IsSuccessStatusCode)
                    return null;
                var result = JsonConvert.DeserializeObject<SupplierClientDTO>(response.Content.ReadAsStringAsync().Result);
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetBaseException().Message);
                return null;
            }

        }

        public async Task<PurchaseOrderDTO> UpdatePurchaseOrder(IRequest<PurchaseOrderDTO> objectRequest)
        {
            try
            {
                if (objectRequest == null)
                    return null;
                var json = JsonConvert.SerializeObject(new
                {
                    objectRequest.ApiKey,
                    mvPurchaseOrder = new
                    {
                        objectRequest.Object.PurchaseOrder.PurchaseOrderInventoryLocationID,
                        objectRequest.Object.PurchaseOrder.PurchaseOrderNo,
                        objectRequest.Object.PurchaseOrder.PurchaseOrderStatus,
                        objectRequest.Object.PurchaseOrder.PurchaseOrderSupplierId,
                        objectRequest.Object.PurchaseOrder.PurchaseOrderTypeId,
                        PurchaseOrderDetails = objectRequest.Object.PurchaseOrder.PurchaseOrderDetails,
                    },
                    objectRequest.MvRecordAction
                });
                var response = await _httpClient.PostAsync("/PurchaseOrder/PurchaseOrderUpdate?", ReturnStringContent(json));
                if (!response.IsSuccessStatusCode)
                    return null;
                var result = JsonConvert.DeserializeObject<PurchaseOrderDTO>(response.Content.ReadAsStringAsync().Result);
                return result;


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.GetBaseException().Message);
                return null;
            }
        }
        public async Task<SalesOrderDTO> AddSalesOrder(IRequest<SalesOrderDTO> objectRequest)
        {
            try
            {
                if (objectRequest == null)
                    return null;
                var json = JsonConvert.SerializeObject(new
                {
                    objectRequest.ApiKey,
                    mvSalesOrder = new
                    {
                        objectRequest.Object.SalesOrder.SalesOrderClientId,
                        objectRequest.Object.SalesOrder.SalesOrderDetails,
                        objectRequest.Object.SalesOrder.SalesOrderInventoryLocationID,
                        objectRequest.Object.SalesOrder.SalesOrderStatus

                    },
                    objectRequest.MvRecordAction
                });
                var response = await _httpClient.PostAsync("SalesOrder/SalesOrderUpdate?", ReturnStringContent(json));
                if (!response.IsSuccessStatusCode)
                    return null;
                var result = JsonConvert.DeserializeObject<SalesOrderDTO>(response.Content.ReadAsStringAsync().Result);
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetBaseException().Message);
                return null;
            }

        }
    }
}
