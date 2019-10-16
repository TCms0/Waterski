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
using System.Windows.Threading;
using Brush = System.Windows.Media.Brush;
using Brushes = System.Windows.Media.Brushes;
using Color = System.Windows.Media.Color;
using Waterskibaan;


namespace Visualisatie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Game game;
        int tellertje = 0;

        public MainWindow()
        {
            this.game = new Game();
            game._OutputStatus = true;
            DispatcherTimer timer = new DispatcherTimer();
            game.Initialize(timer);
            timer.Interval = TimeSpan.FromSeconds(0.1);
            timer.Tick += Timer_Tick;
            timer.Start();
            InitializeComponent();
        }
        void Timer_Tick(object sender, EventArgs e)
        {
            tellertje++;
            TekenwachtrijI();
            Tekeninstrg();
            Tekenwachtstart();
            lijnenwachtrij();
            tekenopdr();
        }
        public void TekenwachtrijI()
        {
            wachtlist.Items.Clear();
            foreach (Sporter sp in game.WachtI.GetAlleSporters())
            {
                wachtlist.Items.Add("Sporter" + sp.Sporternummer);

            }
        }

        public void Tekeninstrg()
        {
            Instrlist.Items.Clear();
            foreach (Sporter sp in game.InstrG.GetAlleSporters())
            {
                Instrlist.Items.Add("Sporter" + sp.Sporternummer);

            }
        }

        public void Tekenwachtstart()
        {
            wachtstartlist.Items.Clear();
            foreach (Sporter sp in game.Wachtst.GetAlleSporters())
            {
                wachtstartlist.Items.Add("Sporter" + sp.Sporternummer);
            }
        }
        public void lijnenwachtrij()
        {
            Lijnenbeschikbaar.Items.Clear();
            Lijnenbeschikbaar.Items.Add("Beschikbaar : " + Waterskibaan.Game.waterb.voorraad.GetAantalLijnen());
            
        }

        public void tekenopdr()
        {
            Spelscherm.Children.Clear();

            int scherm_x = 20;//start x coordinaat
            int scherm_y = 300; //Print rechtelijntjes
            int scherm_x2 = 20;//Schuif op
            int scherm_y2 = 10;
            if (Waterskibaan.Game.waterb.p._lijnen.Count > 0)
            {
                foreach (Lijn lijn in Game.waterb.p._lijnen)
                {
                    Line teken = new Line();
                    var brush = new SolidColorBrush(Color.FromArgb(lijn.Sp.KledingKleur.A, lijn.Sp.KledingKleur.R, lijn.Sp.KledingKleur.G, lijn.Sp.KledingKleur.B));
                    teken.Stroke = brush;
                    teken.X1 = scherm_x;
                    teken.X2 = scherm_x2;
                    teken.Y1 = scherm_y;
                    teken.Y2 = scherm_y2;
                    teken.StrokeThickness = 2;
                    Spelscherm.Children.Add(teken);

                    Label l = new Label();
                    Canvas.SetTop(l, scherm_x2);
                    Canvas.SetLeft(l, scherm_x);
                    l.Content = lijn.Sp.Sporternummer;
                    Spelscherm.Children.Add(l);

                    Label kabel = new Label();

                    scherm_x += 20;
                    scherm_x2 += 20;

                }
            }

        }
    }
}


