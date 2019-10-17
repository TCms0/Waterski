using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    static class MoveCollection
    {
        public static List<IMoves> GetWillekeurigeMoves()
        {

            {
                List<IMoves> Moves = new List<IMoves>();
                Moves.Add(new Jump());
                Moves.Add(new EenArm());
                Moves.Add(new EenBeen());
                Moves.Add(new Omdraaien());

                Random rand = new Random(DateTime.Now.Millisecond);
                List<IMoves> selectedMoves = new List<IMoves>();

                for (int i = 0; i < Moves.Count; i++)
                {
                    var index = rand.Next(Moves.Count());
                    selectedMoves.Add(Moves[index]);
                }

                return selectedMoves;
            }
        }
        public class Jump : IMoves
        {
            public int MoeilijkheidsGraad { get; set; }
            public int Score { get; set; }
            public string Naam { get; set; }
            public int Move()
            {
                Naam = "Sprong";
                MoeilijkheidsGraad = 50;
                Random rand = new Random(DateTime.Now.Millisecond);
                int randomNummer = rand.Next(0, 101);
                if (51 < MoeilijkheidsGraad)
                {
                    return 0;
                }
                else
                {
                    return Score = 30;
                }
            }
        }

        public class Omdraaien : IMoves
        {
            public int MoeilijkheidsGraad { get; set; }
            public int Score { get; set; }
            public string Naam { get; set; }
            public int Move()
            {
                Naam = "Omdraaien";
                MoeilijkheidsGraad = 80;
                Random rand = new Random(DateTime.Now.Millisecond);
                int randomNummer = rand.Next(0, 101);
                if (randomNummer < MoeilijkheidsGraad)
                {
                    return 0;
                }
                else
                {
                    return Score = 60;
                }
            }
        }

        public class EenBeen : IMoves
        {
            public int MoeilijkheidsGraad { get; set; }
            public int Score { get; set; }
            public string Naam { get; set; }
            public int Move()
            {
                Naam = "Een been";
                MoeilijkheidsGraad = 30;
                Random rand = new Random(DateTime.Now.Millisecond);
                int randomNummer = rand.Next(0, 101);
                if (randomNummer < MoeilijkheidsGraad)
                {
                    return 0;
                }
                else
                {
                    return Score = 20;
                }
            }
        }

        public class EenArm : IMoves
        {
            public int MoeilijkheidsGraad { get; set; }
            public int Score { get; set; }
            public string Naam { get; set; }
            public int Move()
            {
                Naam = "Een Arm los";
                MoeilijkheidsGraad = 20;
                Random rand = new Random(DateTime.Now.Millisecond);
                int randomNummer = rand.Next(0, 101);
                if (randomNummer < MoeilijkheidsGraad)
                {
                    return 0;
                }
                else
                {
                    return Score = 10;
                }
            }
        }
    }
}