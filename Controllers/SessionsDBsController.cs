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
    public class SessionsDBsController : Controller
    {
        private readonly OS_GJ_TutoringContext _context;

        public SessionsDBsController(OS_GJ_TutoringContext context)
        {
            _context = context;
        }

        // GET: SessionsDBs
        public async Task<IActionResult> Index()
        {
            return View(await _context.SessionsDB.ToListAsync());
        }

        // GET: SessionsDBs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sessionsDB = await _context.SessionsDB
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sessionsDB == null)
            {
                return NotFound();
            }

            return View(sessionsDB);
        }

        // GET: SessionsDBs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SessionsDBs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TutorName,TutorSubject,Time")] SessionsDB sessionsDB)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sessionsDB);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sessionsDB);
        }

        // GET: SessionsDBs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sessionsDB = await _context.SessionsDB.FindAsync(id);
            if (sessionsDB == null)
            {
                return NotFound();
            }
            return View(sessionsDB);
        }

        // POST: SessionsDBs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TutorName,TutorSubject,Time")] SessionsDB sessionsDB)
        {
            if (id != sessionsDB.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sessionsDB);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SessionsDBExists(sessionsDB.Id))
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
            return View(sessionsDB);
        }

        // GET: SessionsDBs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sessionsDB = await _context.SessionsDB
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sessionsDB == null)
            {
                return NotFound();
            }

            return View(sessionsDB);
        }

        // POST: SessionsDBs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sessionsDB = await _context.SessionsDB.FindAsync(id);
            if (sessionsDB != null)
            {
                _context.SessionsDB.Remove(sessionsDB);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SessionsDBExists(int id)
        {
            return _context.SessionsDB.Any(e => e.Id == id);
        }
    }
}
