using Microsoft.AspNetCore.Mvc;
using MVC_Ornek.Models; 
using System.Collections.Generic;

namespace MVC_Ornek.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            //Örnek müşteri
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Ayşe",
                LastName = "Kara",
                Email = "ayse.kara@email.com"
            };

            //Örnek siparişler
            var orders = new List<Order>
            {
                new Order { Id = 1, ProductName = "Kot Pantolon", Price = 150TL, Quantity = 1 },
                new Order { Id = 2, ProductName = "Etek", Price = 120TL, Quantity = 2 }
            };

            // ViewModel oluşturuluyor
            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            return View(viewModel);
        }
    }
}
