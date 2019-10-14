using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Waterskibaan;

namespace Waterskibaan
{

    public partial class Visualisatie : Window
    {
        public Visualisatie()
        {
            InitializeComponent();
        }


        [STAThread]
        static void Main(string[] args)
        {
            RunApplication();
            TestOpdr12();
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


