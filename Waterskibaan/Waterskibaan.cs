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

        public Waterskibaan()
        {
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
                Console.WriteLine(q);
                voorraad.LijnToevoegenAanRij(q);
            }
        }

        public override string ToString()
        {
            return $"Er zijn {voorraad.ToString()} lijnen op voorraad en er zijn {p.ToString()} Lijnen aan de kabel: ";

        }

        public void SporterStart(Sporter sp)
        {
            if (sp.Skies != null && sp.Zwemvest != null)
            {
                if (p.IsStartPositieLeeg())
                {

                    Lijn l = new Lijn();
                    p.NeemLijnInGebruik(l);
                    l.Addsporter(sp);

                    Random r = new Random();
                    int rondjes = r.Next(2);

                    if (rondjes == 1)
                    { sp.AantalRondenNogTeGaan = 2; }
                    else
                    { sp.AantalRondenNogTeGaan = 1; }
                }
            }
            else
            {
                throw new System.Exception("Sporter heeft geen skies of zwemvest aan");
            }
        }
    }
}
