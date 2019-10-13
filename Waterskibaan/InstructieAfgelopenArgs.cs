using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    class InstructieAfgelopenArgs : EventArgs
    {

        public List<Sporter> SporternrInstructie { get; set; }

        public InstructieAfgelopenArgs(List<Sporter> lijst)
        {
            this.SporternrInstructie = lijst;
        }

        public List<Sporter> verplaatsBeschikbareSporters()
        {
            List<Sporter> returnLijst = new List<Sporter>();
            returnLijst = SporternrInstructie;
            SporternrInstructie.Clear();
            return returnLijst;
        }
    }
}
