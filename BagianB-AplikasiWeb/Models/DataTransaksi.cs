using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BagianB_AplikasiWeb.Models
{
    public partial class DataTransaksi
    {
        public int Id { get; set; }
        public string KodeTransaksi { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? Tanggal { get; set; }
        public string Pelanggan { get; set; }
        public double? Total { get; set; }
    }
}
