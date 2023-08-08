using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kom_zkouska_vap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*DATOVÉ TYPY*/

            /* DATOVÝ TYP    KLÍČOVÝ NÁZEV    VELIKOST             ROZSAH              VLASTNOSTI
               celé číslo        int             4B        -2biliony až 2 biliony      Nelze použít pro desetinné číslo; zapisuje se př.: "int [NÁZEV PROMĚNNÉ] = [ČÍSLO];"
              reálné číslo       float           4B               2 biliony            Lze použít pro desetinné číslo; zapisuje se př.: "float [NÁZEV PROMĚNNÉ] = [ČÍSLO]f; " místo desetinné čárky používáme tečku
                  znak           char            2B              -128 až 127           Zapisuje se př.: "char [NÁZEV] = '[ZNAK NAPŘ. €]';"  místo uvozovek Píšeme mezi znak '
                řetězec          string          4B               2 biliony            Zapisuje se př.: "string [NÁZEV] = "[TEXT];"
            pravdivostní typ     bool            1B               True/False           Příklad: "Svítí žárovka? Ano/Ne" Lze zapsat jako "bool [NAZEV] = true;"
            prázdná hodnota      null            -                    -
            */

            /*PROGRAM, KTERÝ ZJISTÍ, JESTLI JE ZADANÉ ČÍSLO KLADNÉ, ZÁPORNÉ NEBO NULA*/
            
                        Console.WriteLine("Zadejte číslo: ");
                        float cislo = float.Parse(Console.ReadLine());  //Použijeme float, kdyby uživatel chtěl zadat desetinné číslo, příkaz "float.Parse Console.ReadLine()" použijeme, aby uživatel měl možnost zadat hodnotu.

                        if (cislo == 0) //Použijeme 2 znaménka =, protože chceme, aby program porovnal zadanou hodnotu s 0.
                        {
                            Console.WriteLine("Číslo je nula.");
                        }

                        if (cislo >= 1) //Použijeme znaménka >=, aby program se rozhodoval mezi číslem 1 a více.
                        {
                            Console.WriteLine("Číslo je kladné.");
                        }

                        else //Záporné čísla
                        {
                            Console.WriteLine("Číslo je záporné.");
                        }

                        Console.ReadKey(); //Použijeme na konci každého programu či jakéhokoliv kódu, aby program čekal na ukončení uživatelem, program se ukončí jakoukoliv klávesou.
                       
            /*KALKULAČKA*/
           
            Console.WriteLine("Zadejte číslo: ");
            float prvni = float.Parse(Console.ReadLine());
            Console.WriteLine("Jakou chcete operaci? 1 - součet 2 - rozdíl 3 - součin 4 - podíl");
            int volba = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadejte druhé číslo: ");
            float druhe = float.Parse(Console.ReadLine());

            switch (volba)
            {
                case 1:
                    Console.WriteLine(prvni + druhe);
                break;

                case 2:
                    Console.WriteLine(prvni - druhe);
                break;

                case 3:
                    Console.WriteLine(prvni * druhe);
                break;

                case 4:
                    Console.WriteLine(prvni / druhe);
                break;

                default:
                    Console.WriteLine("Zvolená hodnota neexistuje.");
                break;
            }

            Console.ReadKey();
           
            /*PROGRAM, KTERÝ ZJISTÍ JESTLI JE ZADANÉ ČÍSLO LICHÉ, SUDÉ NEBO NULA*/
           
            Console.WriteLine("Zadejte číslo: ");
            float cislo1 = float.Parse(Console.ReadLine());

            if (cislo1 == 0)
            {
                Console.WriteLine("Zadané číslo je nula.");
            }

            if (cislo1%2 == 0)
            {
                Console.WriteLine("Zadané číslo je sudé.");
            }

            else
            {
                Console.WriteLine("Zadané číslo je liché.");
            }

            Console.ReadKey();
           
            /*PRŮMĚR ZE ZADANÝCH ČÍSEL*/

            Console.WriteLine("Zadejte počet čísel: ");
            int pocetCisel = Convert.ToInt32(Console.ReadLine());

            if (pocetCisel <= 0)
            {
                Console.WriteLine("Neplatný počet čísel.");
                return;
            }

            float soucetPrumer = 0;

            for (int i = 1; i <= pocetCisel; i++)
            {
                Console.WriteLine("Zadejte číslo: ");
                float cisloPrumer = float.Parse(Console.ReadLine());
                soucetPrumer += cisloPrumer;
            }

            double prumer = soucetPrumer / pocetCisel;
            Console.WriteLine(prumer);

            Console.ReadKey();

            /*SOUČET ZE ZADANÝCH ČÍSEL*/

            Console.WriteLine("Zadejte počet čísel: ");
            int CislaSoucet = Convert.ToInt32(Console.ReadLine());

            if (CislaSoucet <= 0)
            {
                Console.WriteLine("Neplatný počet čísel.");
                return;
            }

            float soucet = 0;

            for (int i = 1; i <= CislaSoucet; i++)
            {
                Console.WriteLine("Zadejte číslo: ");
                float cisloSoucet = float.Parse(Console.ReadLine());
                soucet += cisloSoucet;
            }

            double Soucet = soucet;
            Console.WriteLine(Soucet);

            Console.ReadKey();

            /*MAXIMUM A MINIMUM POMOCÍ DOČASNÉ PROMĚNNÉ ZE ZADANÝCH ČÍSEL*/
            
            Console.WriteLine("Zadejte počet čísel: ");
            int pocetCiselMaxMin = Convert.ToInt32(Console.ReadLine());

            if (pocetCiselMaxMin <= 0)
            {
                Console.WriteLine("Neplatný počet čísel.");
                return;
            }

            float max = float.MinValue; // Počáteční hodnota pro maximum
            float min = float.MaxValue; // Počáteční hodnota pro minimum

            for (int i = 1; i <= pocetCiselMaxMin; i++)
            {
                Console.WriteLine("Zadejte číslo: ");
                float cisloMaxMin = float.Parse(Console.ReadLine());

                // Porovnání pro maximum
                if (cisloMaxMin > max)
                {
                    max = cislo;
                }

                // Porovnání pro minimum
                if (cisloMaxMin < min)
                {
                    min = cislo;
                }
            }

            Console.WriteLine("Maximum: " + max);
            Console.WriteLine("Minimum: " + min);

            /*POČET KLADNÝCH A ZÁPORNÝCH A NUL ZE ZADANÝCH ČÍSEL*/

            Console.WriteLine("Zadejte počet čísel: ");
            int pocetcisel3 = Convert.ToInt32(Console.ReadLine());

            if (pocetcisel3 <= 0)
            {
                Console.WriteLine("Neplatný počet čísel.");
                return;
            }

            int kladne = 0;
            int zaporne = 0;
            int nuly = 0;

            for(int i = 1; i <= pocetcisel3; i++)
            {
                Console.WriteLine("Zadejte číslo: ");
                float cislo3 = float.Parse(Console.ReadLine());

                if (cislo3 == 0)
                {
                    nuly++;
                }
                if (cislo3 >= 1)
                {
                    kladne++;
                }
                else
                {
                    zaporne++;
                }
            }
            Console.WriteLine("Kladné:" + kladne);
            Console.WriteLine("Záporné: " + zaporne);
            Console.WriteLine("Nuly: " + nuly);

            Console.ReadKey();

            /*POČET ČÍSEL SUDÝCH, LICHÝCH A NUL ZE ZADANÝCH ČÍSEL*/

            Console.WriteLine("Zadejte počet čísel: ");
            int pocetcisel4 = Convert.ToInt32(Console.ReadLine());

            if (pocetcisel4 <= 0)
            {
                Console.WriteLine("Neplatný počet čísel.");
                return;
            }

            int suda = 0;
            int licha = 0;
            int nuly4 = 0;

            for(int i=1; i <= pocetcisel4; i++)
            {
                Console.WriteLine("Zadejte číslo: ");
                float cislo4 = float.Parse(Console.ReadLine());
                if(cislo4 == 0)
                {
                    nuly4++;
                }
                if (cislo4 % 2 == 0)
                {
                    suda++;
                }
                else
                {
                    licha++;
                }
            }
            Console.WriteLine("Nuly: " + nuly4);
            Console.WriteLine("Sudá: " + suda);
            Console.WriteLine("Lichá: " + licha);

            Console.ReadKey();
        }
    }
}
