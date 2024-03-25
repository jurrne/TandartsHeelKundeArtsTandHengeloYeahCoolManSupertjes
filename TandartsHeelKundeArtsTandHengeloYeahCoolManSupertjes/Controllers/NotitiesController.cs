using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TandartsSuperCool.Data;
using TandartsSuperCool.Models;

namespace TandartsSuperCool.Controllers
{
    public class NotitiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NotitiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Notities
        public async Task<IActionResult> Index()
        {
            return View(await _context.Notitie.ToListAsync());
        }

        // GET: Notities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notitie = await _context.Notitie
                .FirstOrDefaultAsync(m => m.ID == id);
            if (notitie == null)
            {
                return NotFound();
            }

            return View(notitie);
        }

        // GET: Notities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Notities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Tekst")] Notitie notitie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(notitie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(notitie);
        }

        // GET: Notities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notitie = await _context.Notitie.FindAsync(id);
            if (notitie == null)
            {
                return NotFound();
            }
            return View(notitie);
        }

        // POST: Notities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Tekst")] Notitie notitie)
        {
            if (id != notitie.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(notitie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NotitieExists(notitie.ID))
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
            return View(notitie);
        }

        // GET: Notities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notitie = await _context.Notitie
                .FirstOrDefaultAsync(m => m.ID == id);
            if (notitie == null)
            {
                return NotFound();
            }

            return View(notitie);
        }

        // POST: Notities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var notitie = await _context.Notitie.FindAsync(id);
            if (notitie != null)
            {
                _context.Notitie.Remove(notitie);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NotitieExists(int id)
        {
            return _context.Notitie.Any(e => e.ID == id);
        }
    }
}
