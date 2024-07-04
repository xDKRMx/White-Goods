using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeyazEsya.Models
{
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }
        public int GarantiSuresi { get; set; }
        [Required]
        [MaxLength(50)]
        public string KategoriIsim { get; set; }
        public List<BeyazEsya> BeyazEsyalar { get; set; }

    }
}