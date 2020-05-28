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
    public class Orders : Controller
    {

        public readonly IOrderService _Orderservice;
        public Orders(IOrderService Orderservice)
        {
            _Orderservice = Orderservice;
        }


        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var orders = await _Orderservice.GetAllOrdersAsync();
            return View(orders);
        }



        public async Task<IActionResult> Details(int id)
        {

            var order = await _Orderservice.GetOrderByIdAsync(id);
            if (order == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(order);
        }


    }
}
