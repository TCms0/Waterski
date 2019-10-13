using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Waterskibaan
{
    class Game : Logger

    {
        public bool _PrintStatus = false;
        public delegate void InstructieAfgelopenHandler(InstructieAfgelopenArgs args);
        public delegate void NieuweBezoekerHandler(NieuweBezoekerArgs args);
        public delegate void LijnenVerplaatst();

        private static System.Timers.Timer aTimer;
        private int teller = 0;

        InstructieGroep InstrG = new InstructieGroep();
        WachtrijInstructie WachtI = new WachtrijInstructie();
        WachtrijStarten Wachtst = new WachtrijStarten();

 
        public event NieuweBezoekerHandler NieuweBezoeker;
        public event InstructieAfgelopenHandler InstructieAfgelopen;
        public event LijnenVerplaatst _LijnenVerplaatst;
        public static Waterskibaan waterb = new Waterskibaan();
 
        public void Initialize()
        {
            SetTimer();
            Console.WriteLine("Start spel");
            NieuweBezoeker += OnNieuweBezoeker;
            InstructieAfgelopen += OnInstructieGroep;
            _LijnenVerplaatst += LijnenVerplaatsen;
            Console.ReadLine();
            aTimer.Stop();
            aTimer.Dispose();
            Console.WriteLine(teller);
        }

        private void SetTimer()
        {
            aTimer = new System.Timers.Timer(1000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            teller++;
            if (teller % 3 == 0)
            {
                NieuweBezoeker.Invoke(new NieuweBezoekerArgs(new Sporter(MoveCollection.GetWillekeurigeMoves())));
                PrintStatus();
            }
            if (teller % 20 == 0)
            {
                int aantal = WachtI.GetAlleSporters().Count > 5 ? 5 : WachtI.GetAlleSporters().Count;
                List<Sporter> splijst = WachtI.SportersVerlatenRij(aantal);
                InstructieAfgelopen.Invoke(new InstructieAfgelopenArgs(splijst));
            }
            if (teller % 4 == 0)
            {
                _LijnenVerplaatst.Invoke();
            }

        }

        private void OnNieuweBezoeker(NieuweBezoekerArgs e)
        {
            WachtI.SporterNeemPlaatsInRij(e.sp);
            
        }

        private void OnInstructieGroep(InstructieAfgelopenArgs e)
        {
            if (InstrG.GetAlleSporters().Count > 0)
            {
                List<Sporter> Instructie = InstrG.SportersVerlatenRij(InstrG.GetAlleSporters().Count);
                foreach (Sporter sp in Instructie)
                {
                    WachtI.SporterNeemPlaatsInRij(sp);
                }
            }

            foreach (Sporter sp in e.SporternrInstructie)
            {
                InstrG.SporterNeemPlaatsInRij(sp);
            }
        }

        public void LijnenVerplaatsen()
        {

            if (waterb.p.IsStartPositieLeeg())
            {
                List<Sporter> Sporterstart = Wachtst.SportersVerlatenRij(1);
                foreach (Sporter sp in Sporterstart)
                {
                    sp.Skies = new Skies();
                    sp.Zwemvest = new Zwemvest();
                    waterb.SporterStart(sp);
                }
            }
            waterb.VerplaatsKabel();
        }

        public void PrintStatus()
        {
            if (_PrintStatus)
            {
                Console.WriteLine(WachtI);
                Console.WriteLine(Wachtst);
                Console.WriteLine($"{InstrG}\n");
            }
        }
    }
}
