using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitapMagaza.Models
{
    public class KitapModel
    {
        public int Id { get; set; }
        public string? KitapAd { get; set; }
        public int SayfaSayisi { get; set; }
    }
}