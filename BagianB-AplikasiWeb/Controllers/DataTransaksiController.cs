using BagianB_AplikasiWeb.Models;
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
    }
}
