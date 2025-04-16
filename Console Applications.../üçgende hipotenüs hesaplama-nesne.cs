using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ClassUcgen
{
    class Ucgen
    {
        double kenar1;
 
        public double Kenar1
        {
            get { return kenar1; }
            set 
            {
                if (value <= 0) // Kenar 0 ve daha küçükse 1 yapıyoruz.
                { 
                    kenar1 = 1; 
                }
                else
                    kenar1 = value;
            }
        }
        double kenar2;
 
        public double Kenar2
        {
            get { return kenar2; }
            set 
            {
                if(value<=0) // Kenar 0 ve daha küçükse 1 yapıyoruz.
                { kenar2 = 1; }
                else
                kenar2 = value; 
            }
        }
 
        public double Alan()
        {
            double ucgenAlan=0;
            ucgenAlan=(kenar1*kenar2)/2;
            return ucgenAlan;
        }
        public double Hipotenus()
        {
            double ucgenHipotenus = 0;
            ucgenHipotenus = Math.Sqrt((Math.Pow(kenar1, 2) + Math.Pow(kenar2, 2)));
            return ucgenHipotenus;
        }
    }
}
 
