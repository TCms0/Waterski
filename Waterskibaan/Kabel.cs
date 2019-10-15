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
            if (_lijnen.Count != 0)
            {
                if (_lijnen.First.Value.PositieOpDeKabel == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

        public void NeemLijnInGebruik(Lijn lijn)
        {
            if (IsStartPositieLeeg())
            {
                lijn.PositieOpDeKabel = 0;
                _lijnen.AddFirst(lijn);
            }
            else
            {
                Console.WriteLine("Deze Positie is vol!");
            }
        }

        public void VerschuifLijnen()
        {
            Lijn lijnswitch = null;
            foreach (Lijn lijn in _lijnen)
            {
                if (lijn.PositieOpDeKabel == 9)
                {
                    lijnswitch = lijn;
                }
                else
                {
                    lijn.PositieOpDeKabel++;
                    lijn.Sp.DoeMove();
                }
            }
            if (lijnswitch != null)
            {
                lijnswitch.PositieOpDeKabel = 0;
                _lijnen.Remove(lijnswitch);
                _lijnen.AddFirst(lijnswitch);
                if (lijnswitch.Sp.AantalRondenNogTeGaan == 1)
                {
                    return;
                }
                lijnswitch.Sp.AantalRondenNogTeGaan--;
            }
        }

            public Lijn VerwijderLijnVanKabel()
            {
                foreach (Lijn lijn in _lijnen)
                {
                    if (lijn.PositieOpDeKabel == 9 && lijn.Sp.AantalRondenNogTeGaan <= 1)
                    {
                        _lijnen.RemoveLast();
                        return _lijnen.Last.Value;
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
