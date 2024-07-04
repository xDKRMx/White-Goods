using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeyazEsya.Models
{
    public class CamasırMakinesi : BeyazEsya
    {
        public int Kutle { get; set; }
        public int ElektrikGucu { get; set; }
        public float Kapasite { get; set; }

    }
}