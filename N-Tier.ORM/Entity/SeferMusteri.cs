using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.ORM.Entity
{
    internal class SeferMusteri
    {
        public int SeferId { get; set; }
        public int MusteriID { get; set; }
        public byte KoltukNo { get; set; }
        public int BinisYeri { get; set; }
        public int InisYeri { get; set; }
        public decimal Ucret { get; set; }
    }
}
