using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    class Program
    {
        static void Main(string[] args)
        {   
            //TestOpdracht2();
            TestOpdracht3();
            //TestOpdracht8();
            //TestOpdracht10();
            //Testopdracht11();
        }

        private static void TestOpdracht2()
        {
            Kabel k = new Kabel();
            Lijn l1 = new Lijn();
            Lijn l2 = new Lijn();
            Lijn l3 = new Lijn();

            //checken van startpositie
            Console.WriteLine(k.IsStartPositieLeeg());
            k.NeemLijnInGebruik(l1);
            Console.WriteLine(k.ToString());
            k.VerschuifLijnen();

            Console.WriteLine(k.IsStartPositieLeeg());
            k.NeemLijnInGebruik(l2);
            Console.WriteLine(k.ToString());
            k.VerschuifLijnen();

            //ingebruik nemen van lijn
            k.NeemLijnInGebruik(l3);
            Console.WriteLine(k.ToString());

            //verschuiven van alle lijnen
            k.VerschuifLijnen();
            Console.WriteLine(k.ToString());

            //verwijderen van een lijn
            k.VerwijderLijnVanKabel();
            Console.WriteLine(k.ToString());
        }

        private static void TestOpdracht3()
        {

            LijnenVoorraad voorraad = new LijnenVoorraad();
            Lijn l1 = new Lijn();
            Lijn l2 = new Lijn();
            Lijn l3 = new Lijn();

            //Toevoegen lijn en uitlezen aantal lijnen in wachtrij
            Console.WriteLine(voorraad.ToString());
            voorraad.LijnToevoegenAanRij(l1);
            Console.WriteLine(voorraad.ToString());

            //Toevoegen lijn 2 en 3 uitlezen aantal lijnen in wachtrij
            voorraad.LijnToevoegenAanRij(l2);
            Console.WriteLine(voorraad.ToString());
            voorraad.LijnToevoegenAanRij(l3);
            Console.WriteLine(voorraad.ToString());

            //verwijderen lijnen 
            voorraad.VerwijderEersteLijn();
            Console.WriteLine(voorraad.ToString());
            voorraad.VerwijderEersteLijn();
            Console.WriteLine(voorraad.ToString());
        }
    }
}
