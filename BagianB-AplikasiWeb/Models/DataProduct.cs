using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BagianB_AplikasiWeb.Models
{
    public partial class DataProduct
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Nama { get; set; }
        [Required]
        public double? Harga { get; set; }
        [Required]
        public string Deskripsi { get; set; }
    }
}
