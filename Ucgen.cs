using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace alan_hesaplama
{
    class Ucgen
    {
       public string ucgen()
        {
            Console.WriteLine("Taban,yükseklik ve üçüncü kenar değerlerini gir.");
            double taban=Convert.ToDouble(Console.ReadLine());
            double yukseklik=Convert.ToDouble(Console.ReadLine());
            double ucuncukenar=Convert.ToDouble(Console.ReadLine());
            double alan=(taban*yukseklik)/2;
            double cevre=taban+yukseklik+ucuncukenar;
            string sonuc="Alan:"+alan+"Çevre:"+cevre;
            return sonuc;
        }
    }
}