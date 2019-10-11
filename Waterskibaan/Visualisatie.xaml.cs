using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Waterskibaan
{
    /// <summary>
    /// Interaction logic for Visualisatie.xaml
    /// </summary>
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
            TestOpdr11();
        }

        private static void RunApplication()
        {
            var application = new Application();
            application.Run(new Visualisatie());
        }


        private static void TestOpdr11()
        {
            Game g = new Game();
            g.Initialize();
        }
    }
}
