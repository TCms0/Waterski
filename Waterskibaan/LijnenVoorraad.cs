using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;


namespace Waterskibaan
{
    class LijnenVoorraad
    {

        Queue<Lijn> _lijnen = new Queue<Lijn>();

        public void LijnToevoegenAanRij(Lijn lijn)
        {
            _lijnen.Enqueue(lijn);
        }

        public Lijn VerwijderEersteLijn()
        {
            if(LijnenVoorraad == 0)
            {
                return null;
            }
            else
            {
                Console.WriteLine($"De voorraad is {LijnenVoorraad} lijnen");
            }
        }


        public int GetAantalLijnen()
        {
            foreach(int r in _lijnen)
            {
                Console.WriteLine(r);
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}