using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    class Waterskibaan
    {
        Kabel p = new Kabel();
        LijnenVoorraad voorraad = new LijnenVoorraad();

        public Waterskibaan(Kabel k)
        {
            p = k;
            for (int i = 0; i < 15; i++)
            {
                voorraad.LijnToevoegenAanRij(new Lijn());

            }
        }

        public void VerplaatsKabel()
        {
            p.VerschuifLijnen();

            Lijn q = p.VerwijderLijnVanKabel();

            if (q != null)
            {
                for (int i = 0; i < 15; i++)
                {


                    Console.WriteLine(q);
                    voorraad.LijnToevoegenAanRij(q);
                }
            }
        }

        public override string ToString()
        {
            return $"Er zijn {voorraad.ToString()} en er zijn {p.ToString()} Lijnen aan de kabel: ";

        }

        public void SporterStart(Sporter sp)
        {
            if (sp.Skies != null && sp.Zwemvest != null)
            {
                if (p.IsStartPositieLeeg())
                {
                    Random r = new Random();
                    int rondjes = r.Next(2);

                    if (rondjes == 1)
                    { sp.AantalRondenNogTeGaan = 2; }
                    else
                    { sp.AantalRondenNogTeGaan = 1; }

                    Lijn l = voorraad.VerwijderEersteLijn();
                    l.sp = sp;
                    p.NeemLijnInGebruik(l);
                    l.Addsporter(sp);
                }
            }
            else
            {
                throw new System.Exception("Sporter heeft geen skies of zwemvest aan");
            }
        }
    }
}
