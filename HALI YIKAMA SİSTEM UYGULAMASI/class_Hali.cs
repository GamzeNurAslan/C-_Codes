using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halı_Yıkama_Fabrikası
{
    class Hali
    {
        public double Metrekare { get; set; }
        public DateTime AlimTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public YikamaDurumu Durum { get; set; } = YikamaDurumu.Yikamda;
        public double Ucret => Metrekare * 20;

        public override string ToString() =>
            $"{Metrekare} m² | {Durum} | {Ucret} TL";
    }
    public enum YikamaDurumu
    {
        Yıkamada,
        TeslimEdildi
    }
}
