using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BeyazEsya.Models
{
    public class BeyazEsyaContext :DbContext
    { 
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<CamasırMakinesi> BeyazEsya { get; set; }
        public DbSet<Sogutucu> Sogutucu { get; set; }
    }
}