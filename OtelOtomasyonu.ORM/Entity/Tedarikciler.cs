using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.ORM.Entity
{
    public class Tedarikciler
    {
        public int Id { get; set; }
        public string adi { get; set; }
        public string Soyadi { get; set; }
        public string SirketAdi { get; set; }
        public string TelNo { get; set; }
        public string Adresi { get; set; }
        public string Mail { get; set; }
        public bool Aktif { get; set; }
    }
}
