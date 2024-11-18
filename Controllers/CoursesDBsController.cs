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
    public class CoursesDBsController : Controller
    {
        private readonly OS_GJ_TutoringContext _context;

        public CoursesDBsController(OS_GJ_TutoringContext context)
        {
            _context = context;
        }

        // GET: CoursesDBs
        public async Task<IActionResult> Index()
        {
            return View(await _context.CoursesDB.ToListAsync());
        }

        // GET: CoursesDBs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coursesDB = await _context.CoursesDB
                .FirstOrDefaultAsync(m => m.Id == id);
            if (coursesDB == null)
            {
                return NotFound();
            }

            return View(coursesDB);
        }

        // GET: CoursesDBs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CoursesDBs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CourseName")] CoursesDB coursesDB)
        {
            if (ModelState.IsValid)
            {
                _context.Add(coursesDB);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(coursesDB);
        }

        // GET: CoursesDBs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coursesDB = await _context.CoursesDB.FindAsync(id);
            if (coursesDB == null)
            {
                return NotFound();
            }
            return View(coursesDB);
        }

        // POST: CoursesDBs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CourseName")] CoursesDB coursesDB)
        {
            if (id != coursesDB.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(coursesDB);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoursesDBExists(coursesDB.Id))
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
            return View(coursesDB);
        }

        // GET: CoursesDBs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coursesDB = await _context.CoursesDB
                .FirstOrDefaultAsync(m => m.Id == id);
            if (coursesDB == null)
            {
                return NotFound();
            }

            return View(coursesDB);
        }

        // POST: CoursesDBs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var coursesDB = await _context.CoursesDB.FindAsync(id);
            if (coursesDB != null)
            {
                _context.CoursesDB.Remove(coursesDB);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CoursesDBExists(int id)
        {
            return _context.CoursesDB.Any(e => e.Id == id);
        }
    }
}
