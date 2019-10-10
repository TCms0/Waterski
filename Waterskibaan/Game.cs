using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Waterskibaan
{
    class Game
    {
        public static Kabel k = new Kabel();
        public static Waterskibaan waterskibaan = new Waterskibaan(k);

        Skies s = new Skies();
        Zwemvest v = new Zwemvest();
        public void Initialize()
        {
            for (int i = 0; i < 9; i++)
            {
                Sporter p = new Sporter(MoveCollection.GetWillekeurigeMoves());
                p.Skies = s;
                p.Zwemvest = v;
                waterskibaan.SporterStart(p);
                waterskibaan.VerplaatsKabel();
                Console.WriteLine(waterskibaan.ToString());
                Thread.Sleep(300);
            }
        }
    }
}
