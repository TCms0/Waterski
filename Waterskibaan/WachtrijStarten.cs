using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    class WachtrijStarten : IWachtrij
    {
        public int MAX_LENGTE_RIJ = 20;
        private Queue<Sporter> sporterrij = new Queue<Sporter>();
        List<Sporter> verlatenrij = new List<Sporter>();
        public List<Sporter> GetAlleSporters()
        {
            {
                List<Sporter> sporterrij = new List<Sporter>();
                foreach (Sporter sp in sporterrij)
                {
                    sporterrij.Add(sp);
                }
                return sporterrij;
            }
        }

        public void SporterNeemPlaatsInRIj(Sporter sporter)
        {
            sporterrij.Enqueue(sporter);
        }


        public List<Sporter> SportersVerlatenRij(int aantal)
        {
            List<Sporter> sporterverlaat = new List<Sporter>();
            for (int i = aantal; i > 0; i--)
            {
                sporterverlaat.Add(sporterrij.Dequeue());
            }
            return sporterverlaat;
        }

        public string tostring()
        {
            String msg = $"Aantal sporters in wachtrij: {sporterrij.Count}";
            return msg;
        }
    }
}
