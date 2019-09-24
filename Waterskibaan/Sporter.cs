using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    class Sporter
    {
        public int AantalRondenNogTeGaan
        {
            get { return AantalRondenNogTeGaan; }
            set { AantalRondenNogTeGaan = 0; }
        }
        public Zwemvest Zwemvest
        {
            get {return Zwemvest; }
            set {Console.WriteLine("Hekkie"); }
        }
        public Skies skies { get; set; }
        public Color KledingKleur { get; set; }
        public List<IMoves> moves { get; set; }

        public Sporter(List<IMoves> moves)
        {
            for (int x = 0; x < moves.Count; x++)
            {
                Console.WriteLine(moves[x]);
            }
        }


    }
}
