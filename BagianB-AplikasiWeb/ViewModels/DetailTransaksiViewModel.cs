using BagianB_AplikasiWeb.Models;

namespace BagianB_AplikasiWeb.ViewModels
{
    public class DetailTransaksiViewModel
    {
        public DataPelanggan DataPelanggan { get; set; }
        public DataTransaksi DataTransaksi { get; set; }
        public DataProduct DataProduct { get; set; }
        public DetailProductPelanggan DetailProductPelanggan { get; set; }
    }
}
