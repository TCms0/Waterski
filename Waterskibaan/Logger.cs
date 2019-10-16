using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    public class Logger
    {
        public Sporter sp;
        public List<Sporter> bezoekers = new List<Sporter>();
        public Kabel kabel;
        public int bezoekerMetRood = 0;
        int highscore = 0;
        int rondesdone = 0;
        public Logger(Kabel k)
        {
            kabel = k;
        }

        public List<Sporter> List10Sporters()
        {
            var tiensporters = (from sporter in bezoekers
                                orderby LichtsteKleur(sporter.KledingKleur) descending
                                select sporter).Take(10);
            List<Sporter> list10sporters = new List<Sporter>();
            list10sporters = tiensporters.ToList();
            return list10sporters;
        }
        public int totaalrondjesgedaan()
        {
            var totaal = bezoekers.Sum(x => x.AantalRondenNogTeGaan);
            return totaal;
        }

        public List<string> UniekeMoves()
        {
            var uniekeMovesLijst = (from lijn in kabel._lijnen
                                    where lijn.Sp.Moves != null
                                    select lijn.Sp.Moves.ToString()).Distinct();

            List<string> uniekeMoves = uniekeMovesLijst.ToList();

            return uniekeMoves;
        }

        public int HighScoreSporter()
        {
            if (totaalBezoekers() > 0)
            {
                highscore = bezoekers.Max(x => x._aantalPT);
            }
            return highscore;
        }
        public void AddList(Sporter sp)
        {
            bezoekers.Add(sp);
            if (ColorsAreClose(sp.KledingKleur, Color.Red))
            {
                bezoekerMetRood++;
            }
        }

        public int totaalBezoekers()
        {
            var totaalBezoekers = from bezoeker in bezoekers
                                  select bezoeker;
            return totaalBezoekers.Count();
        }
        public bool ColorsAreClose(Color a, Color z, int threshold = 100)
        {
            int r = (int)a.R - z.R,
                g = (int)a.G - z.G,
                b = (int)a.B - z.B;
            return (r * r + g * g + b * b) <= threshold * threshold;
        }
        public int LichtsteKleur(Color c)
        {
            int lichtstekleur = c.R * c.R + c.G * c.G + c.B * c.B;
            return lichtstekleur;
        }

    }
}

