using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    class InstructieGroep : IWachtrij
    {
        public int MAX_LENGTE_RIJ = 5;
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
                Console.WriteLine("De Instructiegroep is vol");
            }
        }

        public List<Sporter> SportersVerlatenRij(int aantal)
        {
            verlatenrij.AddRange(sporterrij.GetRange(sporterrij.Count - aantal, sporterrij.Count));
            sporterrij.RemoveRange(sporterrij.Count - aantal, sporterrij.Count);
            return verlatenrij; throw new NotImplementedException();
        }
        public string tostring()
        {
            return $"De instructiegroep heeft {GetAlleSporters().Count()} sporters!";
        }
    }
}
