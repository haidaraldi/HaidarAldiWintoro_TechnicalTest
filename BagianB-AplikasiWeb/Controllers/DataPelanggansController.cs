using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BagianB_AplikasiWeb.Models;

namespace BagianB_AplikasiWeb.Controllers
{
    public class DataPelanggansController : Controller
    {
        private readonly TechnicalTestContext _context;

        public DataPelanggansController(TechnicalTestContext context)
        {
            _context = context;
        }

        // GET: DataPelanggans
        public async Task<IActionResult> Index()
        {
            return View(await _context.DataPelanggan.ToListAsync());
        }

        // GET: DataPelanggans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataPelanggan = await _context.DataPelanggan
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dataPelanggan == null)
            {
                return NotFound();
            }

            return View(dataPelanggan);
        }

        // GET: DataPelanggans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DataPelanggans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nama,Alamat,NoTelp")] DataPelanggan dataPelanggan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dataPelanggan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dataPelanggan);
        }

        // GET: DataPelanggans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataPelanggan = await _context.DataPelanggan.FindAsync(id);
            if (dataPelanggan == null)
            {
                return NotFound();
            }
            return View(dataPelanggan);
        }

        // POST: DataPelanggans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nama,Alamat,NoTelp")] DataPelanggan dataPelanggan)
        {
            if (id != dataPelanggan.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dataPelanggan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DataPelangganExists(dataPelanggan.Id))
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
            return View(dataPelanggan);
        }

        // GET: DataPelanggans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataPelanggan = await _context.DataPelanggan
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dataPelanggan == null)
            {
                return NotFound();
            }

            return View(dataPelanggan);
        }

        // POST: DataPelanggans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dataPelanggan = await _context.DataPelanggan.FindAsync(id);
            _context.DataPelanggan.Remove(dataPelanggan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DataPelangganExists(int id)
        {
            return _context.DataPelanggan.Any(e => e.Id == id);
        }
    }
}
