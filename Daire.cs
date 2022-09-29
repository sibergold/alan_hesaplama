using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace alan_hesaplama
{
    class Daire
    {
        public string daire()
        {
            Console.WriteLine("Yarıçap değerini gir.");
          double   yaricap=Convert.ToDouble(Console.ReadLine());
           double  cevre=2*Math.PI*yaricap;
            double alan=Math.PI*Math.Pow(yaricap,2);
            string sonuc="Alan:"+alan+"Çevre:"+cevre;
            return sonuc;
        }
    }
}