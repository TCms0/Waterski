using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    public abstract class Wachtrij
    {
        private Queue<Sporter> lijst = new Queue<Sporter>();
        public List<Sporter> GetAlleSporters()
        {
            List<Sporter> spList = new List<Sporter>();
            foreach (Sporter sp in lijst)
            {
                spList.Add(sp);
            }
            return spList;
        }

        public void SporterNeemPlaatsInRij(Sporter sporter)
        {
            lijst.Enqueue(sporter);
        }

        public List<Sporter> SportersVerlatenRij(int aantal)
        {
            List<Sporter> spList = new List<Sporter>();
            for (int i = 0; i < aantal; i++)
            {
                spList.Add(lijst.Dequeue());
            }
            return spList;
        }
        public String toString()
        {
            String text = $"Aantal sporters in wachtrij: {lijst.Count}";
            return text;
        }
    }
}