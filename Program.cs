using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace alan_hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine("Hangisinin alan ve çevresi hesaplansın? ");
            Console.WriteLine("Daire için 1.");
            Console.WriteLine("Kare  için 2.");
            Console.WriteLine("Dikdörtgen için 3.");
            Console.WriteLine("Üçgen için 4.");
            Console.WriteLine("Seçimini Yap.");
            int secim=Convert.ToInt32(Console.ReadLine());
         
          
         switch(secim)
         {
            case 1:
            Daire daire=new Daire();
            Console.WriteLine(daire.daire());
            break;
            case 2:
            Kare kare=new Kare();
            Console.WriteLine(kare.kare());
            break;
            case 3:
            Dikdortgen dikdortgen=new Dikdortgen();
            Console.WriteLine(dikdortgen.dikdortgen());
            break;
            case 4:
            Ucgen ucgen=new Ucgen();
            Console.WriteLine(ucgen.ucgen());
            break;
            default :
            Console.WriteLine("Hatalı seçim yaptın bb");
            break;
            }
         }
        }
    }
