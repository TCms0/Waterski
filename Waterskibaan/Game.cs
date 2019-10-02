using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Waterskibaan
{
    class Game
    {
        private static System.Timers.Timer aTimer;
        public static Waterskibaan waterskibaan = new Waterskibaan();

        public void Initialize()
        {
            SetTimer();

            aTimer.Stop();
        }

        private static void SetTimer()
        {
            
            aTimer = new System.Timers.Timer(1000);
            
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Sporter sport = new Sporter(MoveCollection.GetWillekeurigeMoves());
            waterskibaan.SporterStart(sport);
            waterskibaan.VerplaatsKabel();
            Console.WriteLine(waterskibaan.ToString());
        }
    }
}
