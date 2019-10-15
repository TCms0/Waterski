using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    public class Sporter
    {
        private readonly Random random = new Random();
        public int _aantalPT;
        public int AantalRondenNogTeGaan { get; set; }
        public Zwemvest Zwemvest { get; set; }
        public Skies Skies { get; set; }
        private static int _Sporternummer = 0;
        public int Sporternummer;
        public IMoves HuidigeMove { get; set; }
        public Color KledingKleur { get; set; }
        public List<IMoves> Moves { get; set; }

        public Sporter(List<IMoves> moves)
        {
            foreach (IMoves m in moves)
            {
                _aantalPT += m.Moves();
            }
            _Sporternummer++;
            Sporternummer = _Sporternummer;
            Color randomkleur = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            KledingKleur = randomkleur;
            Moves = moves;
        }
        public void DoeMove()
        {
            if (random.Next(4) == 1 && Moves.Count > 0)
            {
                int index = random.Next(Moves.Count);
                HuidigeMove = Moves[index];
            }
        }


    }
}
