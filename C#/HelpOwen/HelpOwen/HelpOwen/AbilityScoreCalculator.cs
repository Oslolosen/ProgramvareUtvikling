using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpOwen
{
    class AbilityScoreCalculator
    {
        public int rollResults = 14;
        public double divideBy = 1.75;
        public int addAmount = 2;
        public int minimum = 3;
        public int score;

        public void CalculateScore()
        {
            double divided = rollResults / divideBy;

            int added = addAmount + (int)divided;

            if(added < minimum)
            {
                score = minimum;
            }
            else
            {
                score = added;
            }
        }
    }
}
