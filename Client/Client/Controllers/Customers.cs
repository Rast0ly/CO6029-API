using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Client.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Client.Controllers
{
    public class Customers : Controller
    {

        public readonly ICustomerService _customerservice;
        public Customers(ICustomerService customerservice)
        {
            _customerservice = customerservice;
        }


        // GET: /<controller>/
        public async Task <IActionResult> Index()
        {
            var customer = await _customerservice.GetAllCustomersAsync();
            return View(customer);
        }
           
        

        public async Task<IActionResult> Details(int id)
        {

            var customer = await _customerservice.GetCustomerByIdAsync(id);
            if (customer == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(customer);
        }

        
    }
}
