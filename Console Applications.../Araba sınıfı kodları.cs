using System;
 
namespace ClassArabaOrnek
{
    internal class Araba
    {
        string marka;
        string model;
        int sonHiz;
        bool calisiyorMu = false;
        int anlikHiz = 0;
 
        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public int SonHiz { get => sonHiz; set => sonHiz = value; }
        public bool CalisiyorMu { get => calisiyorMu; set => calisiyorMu = value; }
        public int AnlikHiz { get => anlikHiz; set => anlikHiz = value; }
 
        public Araba(string marka, string model, int sonHiz)
        {
            Marka = marka;
            Model = model;
            SonHiz = sonHiz;
        }
 
        public string ArabayiCalistir()
        {
            if (!CalisiyorMu)
            {
                CalisiyorMu = true;
                return "Araba çalıştırıldı.";
            }
            else
            {
                return "Araba zaten çalışıyor.";
            }
        }
 
        public string ArabayiDurdur()
        {
            if (anlikHiz == 0)
            {
                CalisiyorMu = false;
                return "Araba durduruldu.";
            }
            else
            {
                return "Araba hareket halindeyken aracı durduramazsınız!!";
            }
        }
 
        public string Hizlan(int hiz)
        {
            if (CalisiyorMu)
            {
                AnlikHiz += hiz;
                if (AnlikHiz > SonHiz)
                {
                    AnlikHiz = SonHiz;
                }
                return $"Araba hızlandı. Anlık Hız: {AnlikHiz} km/h";
            }
            else
            {
                return "Önce arabayı çalıştırmalısınız!";
            }
        }
 
        public string Yavasla(int hiz)
        {
            if (CalisiyorMu)
            {
                AnlikHiz -= hiz;
                if (AnlikHiz < 0)
                {
                    AnlikHiz = 0;
                }
                return $"Araba yavaşladı. Anlık Hız: {AnlikHiz} km/h";
            }
            else
            {
                return "Önce arabayı çalıştırmalısınız!";
            }
        }
    }
}
