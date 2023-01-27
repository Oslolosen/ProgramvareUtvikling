using PickACardUI;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PickACardUI
{
    class CardPicker
    {   
        static Random random = new Random();

        private int sum;
        private string card;

        public string PickSomeCards()
        {
            card = RandomValue()+RandomSuite();

            return this.card;
        }
        private string RandomSuite()
        {
            string[] Suites = { "♣", "♦", "♠", "♥" };

            int indexSuites = random.Next(0, 3);
            
            return Suites[indexSuites];
        }

        private string RandomValue()
        {
            string[] cardValues = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "K", "Q" };

            int indexCardValues = random.Next(0, 12);

            if(indexCardValues > 9)
            {
                sum = 10;
            }
            else
            {
                sum = indexCardValues + 1;
            }
            return cardValues[indexCardValues];
        }
        public int getSum()
        {
            return this.sum;
        }
    }
}
