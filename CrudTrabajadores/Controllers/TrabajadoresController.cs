using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CrudTrabajadores.Data;
using CrudTrabajadores.Models;

namespace CrudTrabajadores.Controllers
{
    public class TrabajadoresController : Controller
    {
        private readonly AppDbContext _context;

        public TrabajadoresController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var trabajadores = await _context.Trabajadores.ToListAsync();
            return View(trabajadores);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Trabajador t)
        {
            if (ModelState.IsValid)
            {
                _context.Add(t);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(t);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var t = await _context.Trabajadores.FindAsync(id);
            if (t == null) return NotFound();
            return View(t);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Trabajador t)
        {
            if (ModelState.IsValid)
            {
                _context.Update(t);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(t);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var t = await _context.Trabajadores.FindAsync(id);
            if (t == null) return NotFound();
            return View(t);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var t = await _context.Trabajadores.FindAsync(id);
            _context.Trabajadores.Remove(t);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
