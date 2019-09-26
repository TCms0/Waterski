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
                if (_lijnen.First.Value.PositieOpDeLijn == 0)
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

        public void NeemLijnInGebruik(Lijn lijn){
           if (IsStartPositieLeeg())
            {
                lijn.PositieOpDeLijn = 0;
                _lijnen.AddFirst(lijn);
            }
            else
            {
                Console.WriteLine("Positie is vol!");
            }
         }

        public void VerschuifLijnen()
        {
            foreach (Lijn lijnverschuif in _lijnen)
            {
                lijnverschuif.PositieOpDeLijn++;
            }

            if (_lijnen.Last.Value.PositieOpDeLijn == 9){  
            
            }
        }

                public Lijn VerwijderLijnVanKabel()
            {
            if (_lijnen.Last.Value.PositieOpDeLijn == 9) 
            {
                
                _lijnen.RemoveLast();

                return _lijnen.Last;
            }
            else
            {
                return null;
            }
        }

        public override string ToString()
        {
           string String = "";
            foreach (Lijn lijn in _lijnen)
            {
                String += (lijn.PositieOpDeLijn + "|");
            }
            return (String.TrimEnd('|') + ".");
        }
    }
}
