using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace alan_hesaplama
{
    class Dikdortgen
    {
        public string dikdortgen()
        {
            Console.WriteLine("Kenar bilgilerini gir.");
            double uzun=Convert.ToDouble(Console.ReadLine());
            double kisa=Convert.ToDouble(Console.ReadLine());
            double alan=uzun*kisa;
            double cevre=(uzun+kisa)*2;
            string sonuc="Alan:"+alan+"Çevre:"+cevre;
            return sonuc;

        }
    }
}