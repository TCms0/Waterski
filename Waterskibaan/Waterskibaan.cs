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
            for(int i =0; i< 15; i++)
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
        
        public string ToString()
        {
            return $"Er zijn {voorraad.ToString()} lijnen op voorraad en er zijn {p.ToString()} Lijnen aan de kabel: ";

        }

    }
}
