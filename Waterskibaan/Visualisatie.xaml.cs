using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading.Tasks;
using System.Timers;
using Waterskibaan;
using System.Windows.Threading;
using System.Data.SqlClient;

namespace Waterskibaan
{

    public partial class Visualisatie : Window
    {
        public Visualisatie()
        {

            SetTimer();
            InitializeComponent();
            lijnvoorraad();
        }

        //Set and start the timer
        private void SetTimer()
        {
            for (int i = 0; i < 100; i++)
            {
                DispatcherTimer dispatcherTimer = new DispatcherTimer();
                dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
                dispatcherTimer.Start();

            }
        }

        [STAThread]
        static void Main(string[] args)
        {
            RunApplication();
            TestOpdr12();
            Game game = new Game();
            game.Initialize();
        }

        private static void RunApplication()
        {
            var application = new Application();
            application.Run(new Visualisatie());

        }

        public void lijnvoorraad()
        {
            lijnenvoorraad_4.Content = "aantal :" + Game.waterb.voorraad.GetAantalLijnen();
        }

        public void Wachtrijaantal()
        {
            wachtrij_aantal.Content = "Aantal : ";
        }
        public void Instructieaantal()
        {
            Instructiegroep.Content = "Aantal " + Instructiegroep.ToString();
        }

        private static void TestOpdr12()
        {

            Game game = new Game();
            game._PrintStatus = true;
            game.Initialize();
        }

        private static void TestOpdr11()
        {
            Game game = new Game();
            game.Initialize();
        }

    }
}


