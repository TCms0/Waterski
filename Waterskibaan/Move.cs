using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    class Move : IMoves
    {
        Random rand = new Random();
        int randomint;
        public int moves()
        {
            randomint = rand.Next(4);

            if (randomint == 0)
            {
                return Jump();
            }
            if (randomint == 1)
            {
                return MetEenHand();
            }
            if (randomint == 2)
            {
                return Omdraaien();
            }
            else
            {
                return OpEenBeen();
            }
        }

        public int VoetaanKabel()
        {
            throw new NotImplementedException();
        }

        int IMoves.Move()
        {
            throw new NotImplementedException();
        }
    }
}
