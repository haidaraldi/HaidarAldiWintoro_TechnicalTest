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
    public class DataProductsController : Controller
    {
        private readonly TechnicalTestContext _context;

        public DataProductsController(TechnicalTestContext context)
        {
            _context = context;
        }

        // GET: DataProducts
        public async Task<IActionResult> Index()
        {
            return View(await _context.DataProduct.ToListAsync());
        }

        // GET: DataProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataProduct = await _context.DataProduct
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dataProduct == null)
            {
                return NotFound();
            }

            return View(dataProduct);
        }

        // GET: DataProducts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DataProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nama,Harga,Deskripsi")] DataProduct dataProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dataProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dataProduct);
        }

        // GET: DataProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataProduct = await _context.DataProduct.FindAsync(id);
            if (dataProduct == null)
            {
                return NotFound();
            }
            return View(dataProduct);
        }

        // POST: DataProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nama,Harga,Deskripsi")] DataProduct dataProduct)
        {
            if (id != dataProduct.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dataProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DataProductExists(dataProduct.Id))
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
            return View(dataProduct);
        }

        // GET: DataProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataProduct = await _context.DataProduct
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dataProduct == null)
            {
                return NotFound();
            }

            return View(dataProduct);
        }

        // POST: DataProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dataProduct = await _context.DataProduct.FindAsync(id);
            _context.DataProduct.Remove(dataProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DataProductExists(int id)
        {
            return _context.DataProduct.Any(e => e.Id == id);
        }
    }
}
