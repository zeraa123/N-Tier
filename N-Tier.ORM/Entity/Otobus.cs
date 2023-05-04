using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.ORM_Otobus.Entity
{
    internal class Otobus
    {
        public int OtobusId { get; set; }
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public string Firma { get; set; }
        public byte Koltuk { get; set; }
    }
}
