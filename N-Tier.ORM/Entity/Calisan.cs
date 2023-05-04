using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.ORM_Otobus.Entity
{
    internal class Calisan
    {
        public int Id { get; set; }
        public int CalisanTipi { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; }
        public DateTime IseBaslamaTarihi { get; set; }
        public char Cinsiyet { get; set; }
    }
}
