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

            /*1 – PROGRAM, KTERÝ ZJISTÍ, JESTLI JE ZADANÉ ČÍSLO KLADNÉ, ZÁPORNÉ NEBO NULA*/
            
                        Console.WriteLine("Zadejte číslo: ");
                        float cislo1 = float.Parse(Console.ReadLine());  //Použijeme float, kdyby uživatel chtěl zadat desetinné číslo, příkaz "float.Parse Console.ReadLine()" použijeme, aby uživatel měl možnost zadat hodnotu.

                        if (cislo1 == 0) //Použijeme 2 znaménka =, protože chceme, aby program porovnal zadanou hodnotu s 0.
                        {
                            Console.WriteLine("Číslo je nula.");
                        }

                        if (cislo1 >= 1) //Použijeme znaménka >=, aby program se rozhodoval mezi číslem 1 a více.
                        {
                            Console.WriteLine("Číslo je kladné.");
                        }

                        if (cislo1<=-1)
                        {
                            Console.WriteLine("Číslo je záporné.");
                        }

                        Console.ReadKey(); //Použijeme na konci každého programu či jakéhokoliv kódu, aby program čekal na ukončení uživatelem, program se ukončí jakoukoliv klávesou.
                       
            /*2 – KALKULAČKA*/
           
            Console.WriteLine("Zadejte číslo: ");
            float prvni2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte druhé číslo: ");
            float druhe2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Jakou chcete operaci? 1 - součet 2 - rozdíl 3 - součin 4 - podíl"); //Napíšeme z důvodu, protože budeme používat switch.
            int volba2 = Convert.ToInt32(Console.ReadLine());

            switch (volba2) //napíšeme název proměnné, kde uživatel zadával danou volbu, v tomhle případě je název proměnné "volba".
            {
                case 1:
                    Console.WriteLine(prvni2 + druhe2);
                break;

                case 2:
                    Console.WriteLine(prvni2 - druhe2);
                break;

                case 3:
                    Console.WriteLine(prvni2 * druhe2);
                break;

                case 4:
                    Console.WriteLine(prvni2 / druhe2);
                break;

                default:
                    Console.WriteLine("Zvolená volba neexistuje."); //default se používá z toho důvodu, když uživatel vybere jinou možnost než z daného výběru.
                break;
            }
            
            Console.ReadKey();
           
            /*3 – PROGRAM, KTERÝ ZJISTÍ JESTLI JE ZADANÉ ČÍSLO LICHÉ, SUDÉ NEBO NULA*/
           
            Console.WriteLine("Zadejte číslo: ");
            float cislo3 = float.Parse(Console.ReadLine());

            if (cislo3 == 0)
            {
                Console.WriteLine("Zadané číslo je nula.");
            }

       else if (cislo3%2 == 0) //[NÁZEV PROMĚNNÉ] [% – MODULO NEBOLI PROCENTO] [DVĚ == Z DŮVODU PROVONÁVÁNÍ HODNOTY]
            {
                Console.WriteLine("Zadané číslo je sudé.");
            }

            if (cislo3%2 == 1)
            {
                Console.WriteLine("Zadané číslo je liché.");
            }

            Console.ReadKey();
           
            /*4 – PRŮMĚR ZE ZADANÝCH ČÍSEL*/

            Console.WriteLine("Zadejte počet čísel: ");
            int pocetcisel4 = Convert.ToInt32(Console.ReadLine());

            if (pocetcisel4 <= 0) //Tuhle podmínku použijeme pokaždé, když v programu bude uživatel zadávat např. počet čísel. To z toho důvodu, abychom si ošetřili, že hodnota nejde pod nulu nebo není nula.
            {
                Console.WriteLine("Neplatný počet čísel.");
                return;
            }

            float soucet4 = 0; //Nastavíme hodnotu proměnné na nulu

            for (int i = 1; i <= pocetcisel4; i++) //"for (promenna; podminka; prikaz)" v tomto případě platí jako: "for (int = i; i<= pocetcisel4; i++)" i++ je inkrementace neboli zvýšení hodnoty o jedna.
            {
                Console.WriteLine("Zadejte číslo: ");
                float cislo4 = float.Parse(Console.ReadLine());
                soucet4 += cislo4; //Zde se hodnota proměnné, kterou jsem dříve nastavovali na nulu změní číslo, změní a sečte s číslem, které jsme zadali nyní.
            } //Vše, co je ve složených závorkách, tak platí pro cyklus.

            double prumer = soucet4 / pocetcisel4; //Nyní proběhne aritmetický průměr (součet čísel [DĚLENO] počtem zadaných čísel).
            Console.WriteLine(prumer);

            Console.ReadKey();

            /*5 – SOUČET ZE ZADANÝCH ČÍSEL*/

            Console.WriteLine("Zadejte počet čísel: ");
            int Cisla5 = Convert.ToInt32(Console.ReadLine());

            if (Cisla5 <= 0)
            {
                Console.WriteLine("Neplatný počet čísel.");
                return;
            }

            float soucet5 = 0;

            for (int i = 1; i <= Cisla5; i++)
            {
                Console.WriteLine("Zadejte číslo: ");
                float cisloSoucet5 = float.Parse(Console.ReadLine());
                soucet5 += cisloSoucet5;
            }

            double Soucet5 = soucet5;
            Console.WriteLine(Soucet5);

            Console.ReadKey();

            /*6 – MAXIMUM A MINIMUM POMOCÍ DOČASNÉ PROMĚNNÉ ZE ZADANÝCH ČÍSEL*/
            
            Console.WriteLine("Zadejte počet čísel: ");
            int pocetcisel6 = Convert.ToInt32(Console.ReadLine());

            if (pocetcisel6 <= 0)
            {
                Console.WriteLine("Neplatný počet čísel.");
                return;
            }

            float max6 = float.MinValue; // Počáteční hodnota pro maximum
            float min6 = float.MaxValue; // Počáteční hodnota pro minimum

            for (int i = 1; i <= pocetcisel6; i++)
            {
                Console.WriteLine("Zadejte číslo: ");
                float cislo6 = float.Parse(Console.ReadLine());

                // Porovnání pro maximum
                if (cislo6 > max6)
                {
                    max6 = cislo6;
                }

                // Porovnání pro minimum
                if (cislo6 < min6)
                {
                    min6 = cislo6;
                }
            }

            Console.WriteLine("Maximum: " + max6);
            Console.WriteLine("Minimum: " + min6);

            /*7 – POČET KLADNÝCH A ZÁPORNÝCH A NUL ZE ZADANÝCH ČÍSEL*/

            Console.WriteLine("Zadejte počet čísel: ");
            int pocetcisel7 = Convert.ToInt32(Console.ReadLine());

            if (pocetcisel7 <= 0)
            {
                Console.WriteLine("Neplatný počet čísel.");
                return;
            }

            int kladne7 = 0;
            int zaporne7 = 0;
            int nuly7 = 0;

            for(int i = 1; i <= pocetcisel7; i++)
            {
                Console.WriteLine("Zadejte číslo: ");
                float cislo7 = float.Parse(Console.ReadLine());
                //Píšeme podmínky, následně píšeme, co se má vykonat, když podmínka je ANO, zvyšujeme hodnotu proměnné o jedna, vždy píšeme proto dvě ++ (př.: nuly7++;)
                if (cislo7 == 0)
                {
                    nuly7++; 
                }
           else if (cislo7 >= 1)
                {
                    kladne7++;
                }
                else
                {
                    zaporne7++;
                }
            }
            Console.WriteLine("Kladné:" + kladne7);
            Console.WriteLine("Záporné: " + zaporne7);
            Console.WriteLine("Nuly: " + nuly7);

            Console.ReadKey();

            /*8 – POČET ČÍSEL SUDÝCH, LICHÝCH A NUL ZE ZADANÝCH ČÍSEL*/

            Console.WriteLine("Zadejte počet čísel: ");
            int pocetcisel8 = Convert.ToInt32(Console.ReadLine());

            if (pocetcisel8 <= 0)
            {
                Console.WriteLine("Neplatný počet čísel.");
                return;
            }

            int suda8 = 0;
            int licha8 = 0;
            int nuly8 = 0;

            for(int i=1; i <= pocetcisel8; i++)
            {
                Console.WriteLine("Zadejte číslo: ");
                float cislo8 = float.Parse(Console.ReadLine());
                if(cislo8 == 0)
                {
                    nuly8++;
                }
           else if (cislo8 % 2 == 0)
                {
                    suda8++;
                }
                if (cislo8 % 2 == 1)
                {
                    licha8++;
                }
            }
            Console.WriteLine("Nuly: " + nuly8);
            Console.WriteLine("Sudá: " + suda8);
            Console.WriteLine("Lichá: " + licha8);

            Console.ReadKey();

        }
        //Všechno zvládneš zlato, myslím na tebe a budu ti posílat vzdáleně sílu, ať to zvládneš, vše dobře dopadne, až budeš mít po zkouškách, miluju tě! <3
    }
}
