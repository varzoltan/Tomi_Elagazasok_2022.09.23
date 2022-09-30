using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomi_Elagazasok_2022._09._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Elágazások
            int x = 18;
            int y = 20;
            //Egyszerű elágazások
            if (x > y) 
            {
                Console.WriteLine("Bizony igaz, és lefut a program.");
            }                    
            else
            {
                Console.WriteLine("Hamis esetén ez az ág fut le!");
            }

            if (x < y)
            {
                if(18 > 12)
                {
                    Console.WriteLine("Bizony igaz, és lefut a belső IF ág!");
                }
                else
                {
                    Console.WriteLine("Bizony hamis, és lefut a belső IF ág!");
                }
            }
            else
            {
                Console.WriteLine("Hamis esetén ez az ág fut le!");
            }

            Console.Write("Kérem adja meg a dolgozat eredményét százalékban: ");
            int szazalek = int.Parse(Console.ReadLine());
            Console.WriteLine(szazalek);
            //int szazalek2 = Convert.ToInt16(Console.ReadLine());
            if (szazalek >= 1 && szazalek <= 20)
            {
                Console.WriteLine("Kedves fiam nem vagy tehetséges!");
            }
            else if (szazalek >= 21 && szazalek <= 40)
            {
                Console.WriteLine("Kedves fiam valamennyire haladsz....");
            }
            else if (szazalek >= 41 && szazalek <= 60)
            {
                Console.WriteLine("Kedves fiam ez már közepes...");
            }
            else if (szazalek >= 61 && szazalek <= 80)
            {
                Console.WriteLine("Kedves fiam ez már jó eredmény...");
            }
            else
            {
                Console.WriteLine("Kedves fiam ez már nagyon jó eredmény...");
            }
            
            Console.Write("Kérem adja meg a hét napját (1 - 7): ");
            int hetNapja = int.Parse(Console.ReadLine());
            switch (hetNapja)
            {
                case 1: Console.WriteLine("Hétfő"); break;
                case 2: Console.WriteLine("Kedd"); break;
                case 3: Console.WriteLine("Szerda"); break;
                case 4: Console.WriteLine("Csütörtök"); break;
                case 5: Console.WriteLine("Péntek"); break;
                case 6: Console.WriteLine("Szombat"); break;
                case 7: Console.WriteLine("Vasárnap"); break;

                //Van egy default ág is, de ez elhagyható!
                default: Console.WriteLine("Nem 1 - 7 közötti számot adtál meg!!!");break;
            }

            //Kiírásnál alkamazzuk
            Console.WriteLine((x < y) ? "Valóban x < y" : "Valóban NEM igaz, hogy x < y");
            Console.ReadKey();
        }
    }
}
