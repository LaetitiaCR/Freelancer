using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationFreelancer.Data;
using WebApplicationFreelancer.Models;

namespace WebApplicationFreelancer.Controllers
{
    public class CustomercatsBisController : Controller
    {

            private readonly FreelancerContext _context;

            public CustomercatsBisController(FreelancerContext context)
            {
                _context = context;
            }



            // GET: Students
            public async Task<IActionResult> Index()
            {
                return View(await _context.Customercats.ToListAsync());
            }



            // GET: Customercats/Details/5
            public async Task<IActionResult> Details(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var customercat = await _context.Customercats
                    .FirstOrDefaultAsync(m => m.CustomercatId == id);
                if (customercat == null)
                {
                    return NotFound();
                }

                return View(customercat);
            }




            // GET: Customercats/Create
            public IActionResult Create()
            {
                return View();
            }


            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create([Bind("CustomercatID, CustomercatName, CustomercatDescription")] Customercat customercat)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(customercat);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(customercat);
            }





            // GET: Customercats/Edit/5
            public async Task<IActionResult> Edit(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var customercat = await _context.Customercats.FindAsync(id);
                if (customercat == null)
                {
                    return NotFound();
                }
                return View(customercat);
            }


            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(int id, [Bind("CustomercatID, CustomercatName, CustomercatDescription")] Customercat customercat)
            {
                if (id != customercat.CustomercatId)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(customercat);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!CustomercatExists(customercat.CustomercatId))
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
                return View(customercat);
            }




            // GET: Customercats/Delete/5
            public async Task<IActionResult> Delete(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var customercat = await _context.Customercats
                    .FirstOrDefaultAsync(m => m.CustomercatId == id);
                if (customercat == null)
                {
                    return NotFound();
                }

                return View(customercat);
            }

            // POST: Customercats/Delete/5
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(int id)
            {
                var customercat = await _context.Customercats.FindAsync(id);
                _context.Customercats.Remove(customercat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            private bool CustomercatExists(int id)
            {
                return _context.Customercats.Any(e => e.CustomercatId == id);
            }
        }
    
}
