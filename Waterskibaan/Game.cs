using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Threading;

namespace Waterskibaan
{
    public class Game

    {

        public bool _PrintStatus = false;
        public delegate void InstructieAfgelopenHandler(InstructieAfgelopenArgs args);
        public delegate void NieuweBezoekerHandler(NieuweBezoekerArgs args);
        public delegate void LijnenVerplaatst();

        public static System.Timers.Timer aTimer;
        private int teller = 0;

        public InstructieGroep InstrG = new InstructieGroep();
        public WachtrijInstructie WachtI = new WachtrijInstructie();
        public WachtrijStarten Wachtst = new WachtrijStarten();


        public event NieuweBezoekerHandler NieuweBezoeker;
        public event InstructieAfgelopenHandler InstructieAfgelopen;
        public event LijnenVerplaatst LijnenVerplaatss;
        public static Waterskibaan waterb = new Waterskibaan();

        public void Initialize(DispatcherTimer timer)
        {
            NieuweBezoeker += OnNieuweBezoeker;
            InstructieAfgelopen += OnInstructieGroep;
            LijnenVerplaatss += LijnenVerplaatsen;
            timer.Tick += OnTimedEvent;
        }


        public void OnTimedEvent(Object source, EventArgs e)
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
                LijnenVerplaatss.Invoke();
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
                    Wachtst.SporterNeemPlaatsInRij(sp);
                }
            }
            foreach (Sporter sp in e.SporternrInstructie)
            {
                InstrG.SporterNeemPlaatsInRij(sp);
            }
        }
        public void LijnenVerplaatsen()
        {
            waterb.VerplaatsKabel();

            if (Wachtst.GetAlleSporters().Count == 0)
            {
                return;
            }
            if (waterb.p.IsStartPositieLeeg())
            {
                Sporter Sporterstart = Wachtst.SportersVerlatenRij(1)[0];

                Sporterstart.Skies = new Skies();
                Sporterstart.Zwemvest = new Zwemvest();

                waterb.SporterStart(Sporterstart);
        }
    }
    public void PrintStatus()
    {
        if (_PrintStatus)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine(WachtI);
            Console.WriteLine(InstrG);
            Console.WriteLine($"{Wachtst}\n");
        }
    }
}
}
