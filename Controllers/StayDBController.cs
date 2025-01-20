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
    public class StayDBController : Controller
    {
        private readonly OS_GJ_TutoringContext _context;

        public StayDBController(OS_GJ_TutoringContext context)
        {
            _context = context;
        }

        // GET: StayDB
        public async Task<IActionResult> Index()
        {
            return View(await _context.StayDB.ToListAsync());
        }

        // GET: StayDB/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stayDB = await _context.StayDB
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stayDB == null)
            {
                return NotFound();
            }

            return View(stayDB);
        }

        // GET: StayDB/Create
        public IActionResult Create()
        {
            ViewBag.RoomNames = new List<String>
            {
                "Lion Lodge",
                "Giraffe Lodge",
                "Leopard Lodge",
                "Elefand Lodge",
                "Zebra Lodge",
                "Meerkat Lodge"

            };
            return View();
        }

        // POST: StayDB/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Date,NumNight,NumVisitors,RoomName")] StayDB stayDB)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stayDB);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stayDB);
        }

        // GET: StayDB/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stayDB = await _context.StayDB.FindAsync(id);
            if (stayDB == null)
            {
                return NotFound();
            }
            return View(stayDB);
        }

        // POST: StayDB/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Date,NumNight,NumVisitors,RoomName")] StayDB stayDB)
        {
            if (id != stayDB.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stayDB);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StayDBExists(stayDB.Id))
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
            return View(stayDB);
        }

        // GET: StayDB/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stayDB = await _context.StayDB
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stayDB == null)
            {
                return NotFound();
            }

            return View(stayDB);
        }

        // POST: StayDB/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stayDB = await _context.StayDB.FindAsync(id);
            if (stayDB != null)
            {
                _context.StayDB.Remove(stayDB);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StayDBExists(int id)
        {
            return _context.StayDB.Any(e => e.Id == id);
        }
    }
}
