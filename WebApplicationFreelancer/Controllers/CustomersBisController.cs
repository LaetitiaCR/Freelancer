using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationConsoleEntity.Data;
using WebApplicationFreelancer.Models;

namespace WebApplicationFreelancer.Controllers
{
 
        public class CustomersBisController : Controller
        {
            private readonly FreelancerContext _context;

            public CustomersBisController(FreelancerContext context)
            {
                _context = context;
            }



            // GET: Students
            public async Task<IActionResult> Index()
            {
                return View(await _context.Customers.ToListAsync());
            }



            // GET: Customers/Details/5
            public async Task<IActionResult> Details(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var customer = await _context.Customers
                    .FirstOrDefaultAsync(m => m.CustomerId== id);
                if (customer == null)
                {
                    return NotFound();
                }

                return View(customer);
            }




            // GET: Customers/Create
            public IActionResult Create()
            {
                return View();
            }

            
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create([Bind("CustomerID, CustomerName, CustomerEmail, CustomercatId")] Customer customer)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(customer);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(customer);
            }





            // GET: Customers/Edit/5
            public async Task<IActionResult> Edit(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var customer = await _context.Customers.FindAsync(id);
                if (customer == null)
                {
                    return NotFound();
                }
                return View(customer);
            }

            
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(int id, [Bind("CustomerID, CustomerName, CustomerEmail, CustomercatId")] Customer customer)
            {
                if (id != customer.CustomerId)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(customer);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!CustomerExists(customer.CustomerId))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    return RedirectToAction(nameof(Index));
                }
                return View(customer);
            }




            // GET: Customers/Delete/5
            public async Task<IActionResult> Delete(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var customer = await _context.Customers
                    .FirstOrDefaultAsync(m => m.CustomerId == id);
                if (customer == null)
                {
                    return NotFound();
                }

                return View(customer);
            }

            // POST: Customers/Delete/5
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(int id)
            {
                var customer = await _context.Customers.FindAsync(id);
                _context.Customers.Remove(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            private bool CustomerExists(int id)
            {
                return _context.Customers.Any(e => e.CustomerId == id);
            }
        }
    
}
