using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mancala.Classes
{
    class peeble
    {
        int value;

        public int calculateWinner(string score1, string score2)
        {
            int p1Score = Int32.Parse(score1);
            int p2Score = Int32.Parse(score2);

            if (p1Score > p2Score)
            {
                return p1Score;
            }
            else if (p1Score < p2Score)
            {
                return p2Score;
            }
            else
            {
                //-1 means they tied. This is a flag to let the condition checks know that it was a tie.
                return -1;
            }
        }
    }
}
