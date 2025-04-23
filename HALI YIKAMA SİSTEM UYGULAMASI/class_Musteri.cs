using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halı_Yıkama_Fabrikası
{
    class Musteri
    {
        public string Ad { get; set; }
        public string Numara { get; set; }
        public string Adres { get; set; }
        public List<Hali> Halilar { get; set; } = new List<Hali>();

        public override string ToString() => $"{Ad}";
    }
}
