using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.ORM.Entity
{
    internal class Musteri
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public char Cinsiyet { get; set; }
        public string TcNO { get; set; }
        public string Telefon { get; set; }
    }
}
