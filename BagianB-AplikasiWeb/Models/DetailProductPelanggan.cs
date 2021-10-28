using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BagianB_AplikasiWeb.Models
{
    public partial class DetailProductPelanggan
    {
        public int Id { get; set; }
        public string Pelanggan { get; set; }
        public int? IdProduk { get; set; }
        public double? Jumlah { get; set; }
    }
}
