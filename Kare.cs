using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace alan_hesaplama
{
    class Kare
    {
        public string kare()
        {
           Console.WriteLine("Kenar bilgisi gir.");
           double kenar=Convert.ToDouble(Console.ReadLine());
           double cevre=4*kenar;
           double alan=kenar*kenar;
           string sonuc="Alan:"+alan+"Çevre:"+cevre;
           return sonuc;
        
        } 
    }
}