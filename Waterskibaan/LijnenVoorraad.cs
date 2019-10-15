using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    public class LijnenVoorraad
    {
        Queue<Lijn> _lijnen = new Queue<Lijn>();

        public void LijnToevoegenAanRij(Lijn lijn)
        {
            if (lijn != null)
            {
                _lijnen.Enqueue(lijn);
            }
        }

        public Lijn VerwijderEersteLijn()
        {
            if (GetAantalLijnen() != 0)
            {
                Lijn l = _lijnen.Dequeue();
                return l;
            }
            else
            {
                return null;
            }
        }

        public int GetAantalLijnen()
        {
            return _lijnen.Count;
        }

        public override string ToString()
        {
            return $"{GetAantalLijnen()} Lijnen op Voorraad";
        }
    }
}
