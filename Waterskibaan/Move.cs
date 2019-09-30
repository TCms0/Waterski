using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    class Move : IMoves
    { 
        Random random = new Random();
        int randomcijfer;
        public int moves()
        {
            randomcijfer = random.Next(4);

            if (randomcijfer == 0)
            {return Jump(); }

            if (randomcijfer == 1)
            {return Achteruit(); }
            
            if (randomcijfer == 2)
            { return Draailucht(); }
                
            else
            { return VoetaanKabel(); }
        
        }

        public int Jump()
        {
            if (Uitvoeren() == 1)
            { return 50; }
           
            else
            {return 0; }
        }

        public int Achteruit()
        {
            if (Uitvoeren() == 1)
            { return 120; }
          
            else
            {return 0; }
        }

        public int Draailucht()
        {
            if (Uitvoeren() == 1)
            { return 155; }
           
            else
            { return 0; }
        }

        public int VoetaanKabel()
        {
            if (Uitvoeren() == 1)
            { return 85; }
           
            else
            {return 0; }
        }

        public int Uitvoeren()
        {
            Random rand = new Random();
            int a = rand.Next(2);

            if (a == 1)
            { return 1; }
            
            else
            { return 0;}
        }

        int IMoves.Move()
        {
            throw new NotImplementedException();
        }
    }
}
