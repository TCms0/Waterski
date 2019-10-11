using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    class Kabel
    {

        LinkedList<Lijn> _lijnen = new LinkedList<Lijn>();


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
            foreach (Lijn lijnverschuif in _lijnen)
            {
                lijnverschuif.PositieOpDeKabel++;
            }

            if (_lijnen.Last.Value.PositieOpDeKabel == 15)
            {
                _lijnen.Last.Value.PositieOpDeKabel = 0;
                _lijnen.AddFirst(_lijnen.Last.Value);
                _lijnen.RemoveLast();
            }
            Console.WriteLine(ToString());
        }

        public Lijn VerwijderLijnVanKabel()
        {
            if (_lijnen.Last.Value.PositieOpDeKabel == 9 && _lijnen.Last.Value.sp.AantalRondenNogTeGaan == 1)
            {
                Lijn lijntje = _lijnen.Last.Value;

                _lijnen.RemoveLast();

                return lijntje;
            }
            else
            {
                return null;
            }
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
