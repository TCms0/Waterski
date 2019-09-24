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
            
            if (_lijnen.AddFirst == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void VerschuifLijnen()
        {

        }
    }
}
