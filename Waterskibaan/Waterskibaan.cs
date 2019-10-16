using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    public class Waterskibaan
    {
        public Kabel p = new Kabel();
        public LijnenVoorraad voorraad = new LijnenVoorraad();

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
            voorraad.LijnToevoegenAanRij(p.VerwijderLijnVanKabel());
        }

        public override string ToString()
        {
            return $"Er zijn {voorraad.ToString()} en er zijn {p.ToString()} Lijnen aan de kabel: ";

        }

        public void SporterStart(Sporter sp)
        {
            if (sp.Skies != null && sp.Zwemvest != null && p.IsStartPositieLeeg())
            {
                Random r = new Random();
                int rondjes = r.Next(2);

                if (rondjes == 1)
                { sp.AantalRondenNogTeGaan = 2; }
                else
                { sp.AantalRondenNogTeGaan = 1; }

                Lijn l = voorraad.VerwijderEersteLijn();
                p.NeemLijnInGebruik(l);

                l.Sp = sp;
                l.Addsporter(sp);
            }

            else
            {
                throw new System.Exception("Sporter heeft geen skies of zwemvest aan");
            }
        }
    }
}
