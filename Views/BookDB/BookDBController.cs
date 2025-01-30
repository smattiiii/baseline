using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OS_GJ_Tutoring.Data;
using OS_GJ_Tutoring.Models;

namespace OS_GJ_Tutoring.Controllers
{
    public class BookDBController : Controller
    {
        private readonly OS_GJ_TutoringContext _context;

        public BookDBController(OS_GJ_TutoringContext context)
        {
            _context = context;
        }

        // GET: BookDB
        public async Task<IActionResult> Index()
        {
            return View(await _context.BookDB.ToListAsync());
        }

        // GET: BookDB/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookDB = await _context.BookDB
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookDB == null)
            {
                return NotFound();
            }

            return View(bookDB);
        }

        // GET: BookDB/Create
        public IActionResult Create()
        {
            ViewBag.YearPasses = new List<String>
            {
                "None",
                "Gold Year Pass",
                "Silver Year Pass"
            };

            return View();
        }

        // POST: BookDB/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,SurName,Time,TicketoneQty,TickettwoQty,TicketthreeQty,TicketfourQty,TicketfiveQty,TicketsixQty,TicketsevenQty,TicketeightQty,YearPass")] BookDB bookDB)
        {
            
            if (ModelState.IsValid)
            {
                _context.Add(bookDB);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bookDB);
        }

        // GET: BookDB/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookDB = await _context.BookDB.FindAsync(id);
            if (bookDB == null)
            {
                return NotFound();
            }
            return View(bookDB);
        }

        // POST: BookDB/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,SurName,Time,TicketoneQty,TickettwoQty,TicketthreeQty,TicketfourQty,TicketfiveQty,TicketsixQty,TicketsevenQty,TicketeightQty,YearPass")] BookDB bookDB)
        {
            if (id != bookDB.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookDB);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookDBExists(bookDB.Id))
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
            return View(bookDB);
        }

        // GET: BookDB/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookDB = await _context.BookDB
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookDB == null)
            {
                return NotFound();
            }

            return View(bookDB);
        }

        // POST: BookDB/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bookDB = await _context.BookDB.FindAsync(id);
            if (bookDB != null)
            {
                _context.BookDB.Remove(bookDB);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookDBExists(int id)
        {
            return _context.BookDB.Any(e => e.Id == id);
        }
    }
}
