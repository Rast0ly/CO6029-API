using Client.Models;
using Microsoft.AspNetCore.Builder;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Threading.Tasks;

namespace Client.Data
{
    public class OrderRepository : IOrderRepository


    {
        private readonly HttpClient _client;
        

        public OrderRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://api.co6029.1620601.win.studentwebserver.co.uk/");

        }

        public async Task<OrderModel> GetOrderByIdAsync(int id)
        {
            try
            {

                var responce = await _client.GetAsync($"api/Orders/{id}");
                if (!responce.IsSuccessStatusCode)
                    return null;

                var body = await responce.Content.ReadAsStringAsync();
                var orders = JsonConvert.DeserializeObject<OrderModel>(body);
                return orders;
            }

            catch (Exception)
            {
                return null;
            }
        }
            
        

        public async Task<IList<OrderModel>> GetAllOrdersAsync()
        {
            try
            {

                var responce = await _client.GetAsync("api/Orders");
                if (!responce.IsSuccessStatusCode)
                    return null;

                var body = await responce.Content.ReadAsStringAsync();
                var orders = JsonConvert.DeserializeObject<List<OrderModel>>(body);
                return orders;
            }

            catch (Exception)
            {
                return null;
            }
        }
    }
}
