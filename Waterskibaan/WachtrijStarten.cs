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
        List<Sporter> sporterrij = new List<Sporter>();
        List<Sporter> verlatenrij = new List<Sporter>();
        public List<Sporter> GetAlleSporters()
        {
            return sporterrij;
        }

        public void SporterNeemPlaatsInRIj(Sporter sp)
        {
            if (sporterrij.Count < MAX_LENGTE_RIJ)
            {
                sporterrij.Add(sp);
            }
            else
            {
                Console.WriteLine("WachtrijStarten is Vol!");
            }
        }


        public List<Sporter> SportersVerlatenRij(int aantal)
        {
            verlatenrij.AddRange(sporterrij.GetRange(sporterrij.Count - aantal, sporterrij.Count));
            sporterrij.RemoveRange(sporterrij.Count - aantal, sporterrij.Count);
            return verlatenrij;
        }

        public string tostring()
        {
            return $"WachtrijStarten heeft {GetAlleSporters().Count()} sporters!";
        }
    }
}
