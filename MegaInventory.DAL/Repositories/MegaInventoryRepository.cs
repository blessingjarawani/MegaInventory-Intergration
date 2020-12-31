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
        private readonly string _httpBaseUrl;
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


        public async Task<WarehouseDTO> AddOrUpdateWareHouse(IRequest<Warehouse> objectRequest)
        {
            try
            {
                if (objectRequest == null)
                    return null;
                var response = await _httpClient.PostAsync("InventoryLocation/InventoryLocationUpdate", objectRequest, new JsonMediaTypeFormatter());
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

        public async Task<ProductDTO> AddOrUpdateProduct(IRequest<Product> objectRequest)
        {
            try
            {
                if (objectRequest == null)
                    return null;
                var response = await _httpClient.PostAsync("Product/ProductUpdate", objectRequest, new JsonMediaTypeFormatter());
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

        public async Task<SupplierClientDTO> AddorUpdateClient(IRequest<Product> objectRequest)
        {
            try
            {
                if (objectRequest == null)
                    return null;
                var response = await _httpClient.PostAsync("SupplierClient/SupplierClientUpdate", objectRequest, new JsonMediaTypeFormatter());
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
                var response = await _httpClient.PostAsync("SalesOrder/SalesOrderUpdate", objectRequest, new JsonMediaTypeFormatter());
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
