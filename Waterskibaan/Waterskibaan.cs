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

            p
        }
        
        public string ToString()
        {
            return d;
        }
    
    }
}
