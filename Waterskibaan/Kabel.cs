using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    public class Kabel
    {

        public LinkedList<Lijn> _lijnen = new LinkedList<Lijn>();


        public Boolean IsStartPositieLeeg()
        {
            return _lijnen.First == null || _lijnen.First.Value.PositieOpDeKabel != 0;
        }

        public void NeemLijnInGebruik(Lijn lijn)
        {
            if (IsStartPositieLeeg())
            {
                _lijnen.AddFirst(lijn);
                lijn.PositieOpDeKabel = 0;

            }
            else
            {
                Console.WriteLine("Deze Positie is vol!");
            }
        }

        public void VerschuifLijnen()
        {
            for (int i = 0; i < _lijnen.Count; i++)
            {
                Lijn l = _lijnen.Last.Value;
                try
                {
                    if (_lijnen.Last != null && _lijnen.Last.Value.PositieOpDeKabel == 9)
                    {
                        l.Sp.AantalRondenNogTeGaan--;
                        l.PositieOpDeKabel = 0;
                        _lijnen.RemoveLast();
                        _lijnen.AddFirst(l);
                    }
                    else
                    {
                        _lijnen.ElementAt(i).PositieOpDeKabel++;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public Lijn VerwijderLijnVanKabel()
        {
            foreach (Lijn lijn in _lijnen)
            {
                if (lijn.Sp.AantalRondenNogTeGaan <= 1 && lijn.PositieOpDeKabel == 9)
                {
                    Lijn l = _lijnen.Last.Value;
                    l.PositieOpDeKabel = 0;
                    _lijnen.RemoveLast();
                    return l;
                }
            }
            return null;
        }

        public override string ToString()
        {
            string Ouput = "";
            foreach (Lijn lijn in _lijnen)
            {
                Ouput += (lijn.PositieOpDeKabel + "|");
            }
            return (Ouput.TrimEnd('|'));
        }
    }
}
