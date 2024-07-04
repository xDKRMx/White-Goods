using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeyazEsya.Models
{
    public enum SogutucuTurleri
    {
        Buzdolabı,
        DerinDondurucu,
        MiniBar
    }
    public class Sogutucu
    {
        public SogutucuTurleri Sogutucular { get; set; }
    }
}