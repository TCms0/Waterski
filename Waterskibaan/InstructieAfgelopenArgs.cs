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
    }
}
