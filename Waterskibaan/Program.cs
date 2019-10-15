using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Waterskibaan
{
    class Program
    {
        public static void Main(string[] args)
        {
             TestOpdr2();
            TestOpdr3();
             TestOpdr8();
             TestOpdr10();
              TestOpdr11();
           // TestOpdr12();
        }

        private static void TestOpdr2()
        {
            Kabel k = new Kabel();
            Lijn l1 = new Lijn();
            Lijn l2 = new Lijn();


            Console.WriteLine(k.IsStartPositieLeeg());
            k.NeemLijnInGebruik(l1);
            Console.WriteLine(k.ToString());
            k.VerschuifLijnen();

            Console.WriteLine(k.IsStartPositieLeeg());
            k.NeemLijnInGebruik(l2);
            Console.WriteLine(k.ToString());
            k.VerschuifLijnen();
            Console.WriteLine("--------------------------------------------- \n");

        }

        private static void TestOpdr3()
        {

            LijnenVoorraad voorraad = new LijnenVoorraad();
            Lijn l = new Lijn();
            Lijn k = new Lijn();

            Console.WriteLine(voorraad.ToString());
            voorraad.LijnToevoegenAanRij(l);
            Console.WriteLine(voorraad.ToString());

            voorraad.LijnToevoegenAanRij(k);
            Console.WriteLine(voorraad.ToString());

            voorraad.VerwijderEersteLijn();
            Console.WriteLine(voorraad.ToString());

            Console.WriteLine("--------------------------------------------- \n");
        }

        private static void TestOpdr8()
        {
            Sporter s = new Sporter(MoveCollection.GetWillekeurigeMoves());
            Waterskibaan waterskibaan = new Waterskibaan();

            s.Zwemvest = new Zwemvest();
            s.Skies = new Skies();

            waterskibaan.SporterStart(s);
         /*   foreach (var punt in s.Moves)
            {
                Console.WriteLine(punt);
            }
    */       
    Console.WriteLine(s.KledingKleur);
            Console.WriteLine("--------------------------------------------- \n");

        }

        private static void TestOpdr10()
        {
            InstructieGroep instgroep = new InstructieGroep();
            WachtrijInstructie wachtins = new WachtrijInstructie();
            WachtrijStarten wachtsta = new WachtrijStarten();

            Sporter s1 = new Sporter(MoveCollection.GetWillekeurigeMoves());
            Sporter s2 = new Sporter(MoveCollection.GetWillekeurigeMoves());
            Sporter s3 = new Sporter(MoveCollection.GetWillekeurigeMoves());

            wachtins.MAX_LENGTE_RIJ = 1;

            wachtins.SporterNeemPlaatsInRij(s1);
            wachtins.SporterNeemPlaatsInRij(s2);

            Console.WriteLine(wachtins.ToString());

        }

        private static void TestOpdr11()
        {
            Game game = new Game();
         //   game.Initialize;
        }

        private static void TestOpdr12()
        {

                 DispatcherTimer timer = new DispatcherTimer();
                Game game = new Game();
                game.Initialize(timer);
                timer.Interval = TimeSpan.FromSeconds(1);
                timer.Tick += timer_Tick;
                timer.Start();
                Console.ReadLine();
            }

            public static void timer_Tick(object sender, EventArgs e)
            {
                Console.WriteLine("ttt");
            }
        }
}
