using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    static class MoveCollection
    {
        public static List<IMoves> GetWillekeurigeMoves()
        {
           
            List<IMoves> moveslijst = new List<IMoves>();
            Random rand = new Random();
            int randomgetal = rand.Next(10);

            for (int i = 0; i <= randomgetal; i++)
            {
                moveslijst.Add(new Move());
            }

            return moveslijst;
        }
    }
}
