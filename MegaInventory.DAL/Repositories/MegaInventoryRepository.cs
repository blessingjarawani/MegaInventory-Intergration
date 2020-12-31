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


        public async Task<WarehouseDTO> AddOrUpdateWareHouse(IRequest<WarehouseDTO> objectRequest)
        {
            try
            {
                if (objectRequest == null)
                    return null;
                var json = JsonConvert.SerializeObject(new { objectRequest.ApiKey, mvInventoryLocation = objectRequest.Object.Warehouse, objectRequest.MvRecordAction });

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
            return new StringContent(json.ToString(), Encoding.UTF8, "application/json");
        }

        public async Task<ProductDTO> AddOrUpdateProduct(IRequest<ProductDTO> objectRequest)
        {
            try
            {
                if (objectRequest == null)
                    return null;
                var json = JsonConvert.SerializeObject(new { objectRequest.ApiKey, mvProduct = objectRequest.Object.Product, objectRequest.MvRecordAction });
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

        public async Task<SupplierClientDTO> AddorUpdateClient(IRequest<SupplierClientDTO> objectRequest)
        {
            try
            {
                if (objectRequest == null)
                    return null;
                var json = JsonConvert.SerializeObject(new { objectRequest.ApiKey, mvSupplierClient = objectRequest.Object.SupplierClient, objectRequest.MvRecordAction });
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

        public async Task<SalesOrderDTO> AddSalesOrder(IRequest<SalesOrderDTO> objectRequest)
        {
            try
            {
                if (objectRequest == null)
                    return null;
                var json = JsonConvert.SerializeObject(new { objectRequest.ApiKey, mvSalesOrder = objectRequest.Object.SalesOrder, objectRequest.MvRecordAction });
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
