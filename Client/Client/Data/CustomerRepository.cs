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
    public class CustomerRepository : ICustomerRepository


    {
        private readonly HttpClient _client;
        

        public CustomerRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://api.co6029.1620601.win.studentwebserver.co.uk/");

        }

        public async Task<CustomerModel> GetCustomerByIdAsync(int id)
        {
            try
            {

                var responce = await _client.GetAsync($"api/Customers/{id}");
                if (!responce.IsSuccessStatusCode)
                    return null;

                var body = await responce.Content.ReadAsStringAsync();
                var customers = JsonConvert.DeserializeObject<CustomerModel>(body);
                return customers;
            }

            catch (Exception)
            {
                return null;
            }
        }
            
        

        public async Task<IList<CustomerModel>> GetAllCustomersAsync()
        {
            try
            {

                var responce = await _client.GetAsync("api/Customers");
                if (!responce.IsSuccessStatusCode)
                    return null;

                var body = await responce.Content.ReadAsStringAsync();
                var customers = JsonConvert.DeserializeObject<List<CustomerModel>>(body);
                return customers;
            }

            catch (Exception)
            {
                return null;
            }
        }
    }
}
