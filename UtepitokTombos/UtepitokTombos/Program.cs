using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtepitokTombos
{
    class Program
    {
        static double[] UtHosszaTMB = new double[18];
        static int[] DolgozokSzamaTMB = new int[18];
        static string[] MuvezetoTMB = new string[18];
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Feladat1(); Console.WriteLine("\n-----------------------------------\n");
            Feladat2(); Console.WriteLine("\n-----------------------------------\n");
            Feladat3(); Console.WriteLine("\n-----------------------------------\n");
            Feladat4(); Console.WriteLine("\n-----------------------------------\n");
            Feladat5(); Console.WriteLine("\n-----------------------------------\n");
            Feladat6(); Console.WriteLine("\n-----------------------------------\n");
            //Bonusz
            Feladat7(); Console.WriteLine("\n-----------------------------------\n");
            Feladat8(); Console.WriteLine("\n-----------------------------------\n");

            Console.ReadKey();
        }

        private static void Feladat8()
        {
            Console.WriteLine("8.Feladat: Keresés");
            Console.Write("\tKérem adja meg a keresett művezető nevét: ");
            string KulcsNev = Console.ReadLine().ToLower().Replace(" ","");
            int Szamlalo = 0;
            while(Szamlalo<MuvezetoTMB.Length && KulcsNev!=MuvezetoTMB[Szamlalo].ToLower().Replace(" ",""))
            {
                Szamlalo++;
            }
            if(Szamlalo==MuvezetoTMB.Length)
            {
                Console.WriteLine("\tSajnos nincs ilyen művezetó a listában");
            }
            else
            {
                Console.WriteLine("\tMűvezető: {0} ", KulcsNev);
                Console.WriteLine("\tNap: {0}",Szamlalo+1);
                Console.WriteLine("\tÉpített út hossza: {0}", UtHosszaTMB[Szamlalo]);
                Console.WriteLine("\tDolgozók száma: {0}", DolgozokSzamaTMB[Szamlalo]);

            }
        }

        private static void Feladat7()
        {
            Console.WriteLine("7.Feladat: Művezetők rögzítése kiiratása");
            MuvezetoTMB = new string[18] { "Apród Adrián", "László Péter", "Pataki Olivér", "Juhász Dániel", "Varga Gábor", "Bodnár Benedek", "Bács Bence", " Barta Csaba", "Fekete Ábel", "Vászoly András", "Veres Noel", "Csatár Dezső", "Fodor Zalán", "Farkas Roland", "Balla Géza", "Tamás András", "Apród Valentin", "Bodnár Dániel" };
            for (int i = 0; i < 18; i++)
            {
                Console.WriteLine("\t{0:00}. nap-> út hossza: {1:0.00} méter -> dolgozók száma: {2:00} fő -> művezető: {3}", i + 1, UtHosszaTMB[i], DolgozokSzamaTMB[i], MuvezetoTMB[i]);
            }
        }

        private static void Feladat6()
        {
            Console.WriteLine("6.Feladat: Hány alkalommal volt 65 m feletti");
            int db = 0;
            for (int i = 0; i < 18; i++)
            {
                if(UtHosszaTMB[i]>=65)
                { db++; }
            }
            Console.WriteLine("\tEnnyi alkalommal volt 65 méter feletti a megépített út hossza: {0}", db);
        }

        private static void Feladat5()
        {
            Console.WriteLine("5.Feladat: legrövidebb út és a legkevesebb dolgozó");
            double MinUt = double.MaxValue;
            int MinDolgozok = int.MaxValue;
            for (int i = 0; i < UtHosszaTMB.Length; i++)
            {
                if (MinUt > UtHosszaTMB[i])
                {
                    MinUt = UtHosszaTMB[i];
                }
                if (MinDolgozok > DolgozokSzamaTMB[i])
                {
                    MinDolgozok = DolgozokSzamaTMB[i];
                }
            }
            Console.WriteLine("\tA legrövidebb megépített út hossza: {0}", MinUt);
            Console.WriteLine("\tA legkevesebb dolgozó száma: {0}", MinDolgozok);
        }

        private static void Feladat4()
        {
            Console.WriteLine("4.Feladat: leghosszabb út és a legtöbb dolgozó");
            double MaxUt = double.MinValue;
            int MaxDolgozok = int.MinValue;
            for (int i = 0; i < UtHosszaTMB.Length; i++)
            {
                if(MaxUt<UtHosszaTMB[i])
                {
                    MaxUt = UtHosszaTMB[i];
                }
                if(MaxDolgozok<DolgozokSzamaTMB[i])
                {
                    MaxDolgozok = DolgozokSzamaTMB[i];
                }
            }
            Console.WriteLine("\tA leghosszabb megépített út hossza: {0}", MaxUt);
            Console.WriteLine("\tA legtöbb dolgozó száma: {0}", MaxDolgozok);
        }

        private static void Feladat3()
        {
            Console.WriteLine("3.Feladat: dolgozók számának és a megépített út hosszának átlaga");
            double MegepitettUtOsszege = 0;
            double MegepitettUtAtlaga = 0;
            int DolgozokSzamanakOsszege = 0;
            int DolgozokSzamanakAtlaga = 0;
            for (int i = 0; i < UtHosszaTMB.Length; i++)
            {
                MegepitettUtOsszege += UtHosszaTMB[i];
                DolgozokSzamanakOsszege += DolgozokSzamaTMB[i];
            }
            MegepitettUtAtlaga = MegepitettUtOsszege / UtHosszaTMB.Length;
            DolgozokSzamanakAtlaga = DolgozokSzamanakOsszege / DolgozokSzamaTMB.Length;
            Console.WriteLine("\tA megépített út hosszának átlaga: {0:0.00}", MegepitettUtAtlaga);
            Console.WriteLine("\tA dolgozók számának átlaga: {0:0.00}", DolgozokSzamanakAtlaga);
        }

        private static void Feladat2()
        {
            Console.WriteLine("2.Feladat: Adatok kiíratása");
            for (int i = 0; i < 18; i++)
            {
                Console.WriteLine("\t{0:00}. nap-> út hossza: {1:0.00} méter -> dolgozók száma: {2:00} fő", i+1,UtHosszaTMB[i],DolgozokSzamaTMB[i]);
            }
        }

        private static void Feladat1()
        {
            Console.WriteLine("1.Feladat: Adatok feltöltése ");
            double UtHossz;
            int DolgozokSzama;
            for (int i = 0; i < 18; i++)
            {
                UtHossz = rnd.Next(5055, 7576)/100.00;
                UtHosszaTMB[i] = UtHossz;
                DolgozokSzama = rnd.Next(8, 13);
                DolgozokSzamaTMB[i] = DolgozokSzama;
            }
        }
    }
}
