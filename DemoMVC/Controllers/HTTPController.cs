using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoMVC.Data;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class HTTPController : Controller
    {
        private readonly ApplicationDbcontext _context;

        public HTTPController(ApplicationDbcontext context)
        {
            _context = context;
        }

        // GET: HTTP
        public async Task<IActionResult> Index() => View(await _context.HTTP.ToListAsync());

        // GET: HTTP/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hTTP = await _context.HTTP
                .FirstOrDefaultAsync(m => m.MaHTTP == id);
            if (hTTP == null)
            {
                return NotFound();
            }

            return View(hTTP);
        }
        // GET: HTTP/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HTTP/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaHTTP,TenHTTP2")] HTTP hTTP)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hTTP);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hTTP);
        }

        // GET: HTTP/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hTTP = await _context.HTTP.FindAsync(id);
            if (hTTP == null)
            {
                return NotFound();
            }
            return View(hTTP);
        }

        // POST: HTTP/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaHTTP,TenHTTP2")] HTTP hTTP)
        {
            if (id != hTTP.MaHTPP)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hTTP);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HTTPExists(hTTP.MaHTPP))
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
            return View(hTTP);
        }

        // GET: HTTP/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hTTP = await _context.HTTP
                .FirstOrDefaultAsync(m => m.MaHTTP == id);
            if (hTTP == null)
            {
                return NotFound();
            }

            return View(hTTP);
        }

        // POST: HTTP/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var hTTP = await _context.HTTP.FindAsync(id);
            if (hTTP != null)
            {
                _context.HTTP.Remove(hTTP);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HTTPExists(string id)
        {
            return _context.HTTP.Any(e => e.MaHTTP == id);
        }
    }
}
