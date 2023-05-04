using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.ORM_Otobus.Entity
{
    internal class Sefer
    {
        public int Id { get; set; }
        public int OtobusID { get; set; }
        public DateTime KalkisTarihSaat { get; set; }
        public DateTime VarisTarihSaat { get; set; }
        public byte YolculukSuresi { get; set; }

    }
}
