using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationFreelancer.Models;

namespace WebApplicationFreelancer.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            Customers customers1 = new Customers
            {
                customerId = 1,   
                customer_name = "Mark Zoukerbergue",
                customer_email = "mark@gmail.com"
            };

            Customers customers2 = new Customers
            {
                customerId = 2,
                customer_name = "Jean Thil",
                customer_email = "jeanh@domain.com"
            };

            Customers customers3 = new Customers
            {
                customerId = 3,
                customer_name = "Jessie Aboard",
                customer_email = "jaboard@domail.com"
            };

            ViewBag.Customers = "customers";

            return View("CustomersIndex");
        }
        public IActionResult Test()
        {
            return View();
        }
    }
}
