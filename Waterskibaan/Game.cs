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

        private WachtrijInstructie wachtrijInstructie = new WachtrijInstructie();
        public InstructieGroep instructieGroep = new InstructieGroep();

        public delegate void NieuweBezoekerHandler(NieuweBezoekerArgs args);
        public event NieuweBezoekerHandler NieuweBezoeker;

        public delegate void InstructieAfgelopenHandler(InstructieAfgelopenArgs args);
        public event InstructieAfgelopenHandler InstructieAfgelopen;
       


        Skies s = new Skies();
        Zwemvest v = new Zwemvest();
        public void Initialize()
        {
            NieuweBezoeker += OnNieuweBezoeker;
            InstructieAfgelopen += OnInstructieGroep;
            for (int i = 0; i < 9; i++)
            {
                Sporter p = new Sporter(MoveCollection.GetWillekeurigeMoves());
                p.Skies = s;
                p.Zwemvest = v;
                waterskibaan.SporterStart(p);
                waterskibaan.VerplaatsKabel();
                Console.WriteLine("Kabel verplaatst");
                waterskibaan.ToString();
                Thread.Sleep(1000);
                wachtrijInstructie.ToString();
                InstructieAfgelopen.ToString();
                NieuweBezoeker.Invoke(new NieuweBezoekerArgs(new Sporter(MoveCollection.GetWillekeurigeMoves())));
                Console.WriteLine(wachtrijInstructie.ToString());
                Console.WriteLine(instructieGroep.ToString());
                Console.WriteLine("--------------------");
            }
        }

        private void OnNieuweBezoeker(NieuweBezoekerArgs e)
        {
            wachtrijInstructie.SporterNeemPlaatsInRIj(e.sp);
        }

        private void OnInstructieGroep(InstructieAfgelopenArgs e)
        {
            InstructieAfgelopenArgs instructieAfgelopenArgs = new InstructieAfgelopenArgs();
            instructieAfgelopenArgs.SporternrInstructie = wachtrijInstructie.SportersVerlatenRij(5);
            OnInstructieGroep(instructieAfgelopenArgs);
        }
    }
}