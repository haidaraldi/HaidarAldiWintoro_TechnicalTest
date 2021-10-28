using BagianB_AplikasiWeb.Models;
using BagianB_AplikasiWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BagianB_AplikasiWeb.Controllers
{
    public class DataTransaksiController : Controller
    {
        private readonly TechnicalTestContext _context;

        public DataTransaksiController(TechnicalTestContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.DataTransaksi.ToListAsync());
        }

        public async Task<IActionResult> Details(string pelanggan)
        {
            if (pelanggan == null)
            {
                return NotFound();
            }

            var dataPelanggan = await _context.DataPelanggan
               .FirstOrDefaultAsync(m => m.Nama == pelanggan);  
            
            var dataTransaksi = await _context.DataTransaksi
               .FirstOrDefaultAsync(m => m.Pelanggan == pelanggan);

            var detailProductPelanggan = await _context.DetailProductPelanggan
              .FirstOrDefaultAsync(m => m.Pelanggan == pelanggan); 
            
            var DataProduct = await _context.DataProduct
              .FirstOrDefaultAsync(m => m.Id == detailProductPelanggan.IdProduk);

            if (dataPelanggan == null)
            {
                return NotFound();
            }

            return View(new DetailTransaksiViewModel{ DataPelanggan = dataPelanggan, DataTransaksi = dataTransaksi, DataProduct = DataProduct, DetailProductPelanggan = detailProductPelanggan});
        }
    }
}
