using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BeyazEsya.Models
{
    [ComplexType]
    public class Boyut
    {
        public int Boy { get; set; }
        public int En { get; set; }
        public int Derinlik { get; set; }
    }
    public abstract class BeyazEsya : Boyut
    {
        [Key]
        public int BeyazEsyaID { get; set; }
        public  string Model { get; set; }
        public string Tur { get; set; }
        public int UretimnYılı { get; set; }
        public Boyut Boyut { get; set; }
        public Kategori Kategori { get; set; }

    }
}