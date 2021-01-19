using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationConsoleEntity.Data;
using WebApplicationFreelancer.Data;
using WebApplicationFreelancer.Models;

namespace WebApplicationFreelancer.Controllers
{
    public class FreelancerController : Controller
    {

        /*
        private readonly FreelancerContext _context;

        public MyController(FreelancerContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //return View();
        }
        */


        // Contexte de base de données
        FreelancerContext ctx;

        public FreelancerController(FreelancerContext ctx)
        {
            this.ctx = ctx;
        }


        public IActionResult Index()
        {
            // récupération des voitures enregistrées en base de données
            IEnumerable<Customer> Customers = ctx.Customers.ToList();

            // injection de la liste des voitures dans la vue CarsList
            return View("CustomerList", Customers);
        }


        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                ctx.Customers.Add(customer);

                ctx.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(customer);
        }

    }
}
