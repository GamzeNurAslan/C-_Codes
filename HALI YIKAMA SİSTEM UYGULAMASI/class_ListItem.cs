using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halı_Yıkama_Fabrikası
{
    class ListItem
    {
        public Hali Hali { get; set; }
        public Musteri Musteri { get; set; }

        public ListItem(Hali hali, Musteri musteri)
        {
            Hali = hali;
            Musteri = musteri;
        }

        public override string ToString() =>
            $"{Musteri.Ad} - {Hali.Metrekare} m² - {Hali.Durum}";
    }
}

