using PickACardUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PickACardUI
{
    class BlackJack
    {
        CardPicker cardPicker = new CardPicker();

        public int amountOfDealerCards = 0;
        public int amountOfPlayerCards = 0;

        public int dealerSum = 0;
        public int playerSum = 0;

        public string[] dealerCards = new string[10];
        public string[] playerCards = new string[10];

        public void startBlackJack()
        {
          

            for(int i = 0;i < 2; i++)
            {
                getPlayerCards();
                getDealerCards();
            }
        }
        private void getPlayerCards()
        {
            string card;

            while (true)
            {   
                card = cardPicker.PickSomeCards();

                if (checkForDuplicatesPlayercardsCards(card) == true || checkForDuplicatesDealerCards(card) == true)
                {
                    playerCards[amountOfPlayerCards] = card;
                    playerSum += cardPicker.getSum();
                    amountOfPlayerCards += 1;
                    break;
                }
            }
        }

        public void resetBlackJack()
        {
            amountOfDealerCards = 0;
            amountOfPlayerCards = 0;

            dealerSum = 0;
            playerSum = 0;

            playerCards = new string[10];
            dealerCards = new string[10];
        }

        private void getDealerCards()
        {
            string card;

            while (true)
            {
                card = cardPicker.PickSomeCards();

                if (checkForDuplicatesPlayercardsCards(card) == true || checkForDuplicatesDealerCards(card) == true)
                {
                    dealerCards[amountOfDealerCards] = card;
                    dealerSum += cardPicker.getSum();
                    amountOfDealerCards += 1;
                    break;
                }
            }
        }
        private void Hit()
        {
            getPlayerCards();
            checkCardsPlayer();
        }
        private void checkCardsPlayer()
        {
            Console.WriteLine("Player");
            playerCards.ToList().ForEach(card => Console.Write(card + " "));
            Console.WriteLine("Sum = " + playerSum);
        }
        
        private void checkCardsDealer()
        {
            Console.WriteLine("Dealer");
            Console.WriteLine(dealerCards[0] + "        Hidden last card");
            Console.WriteLine("Sum = " + (dealerSum-cardPicker.getSum()));
            Console.WriteLine();
        }
        private void checkAllCardsDealer()
        {
            Console.WriteLine("Dealer");
            dealerCards.ToList().ForEach(card => Console.Write(card + " "));
            Console.WriteLine("Sum = " + dealerSum);
            Console.WriteLine();
        }
        
        private bool checkForDuplicatesDealerCards(string card)
        {
            bool test = true;

            for (int i = 0; i < amountOfDealerCards; i++)
            {
                if(card == dealerCards[i])
                {
                    test = false;
                    break;
                }
            }
            return test;
        }
        private bool checkForDuplicatesPlayercardsCards(string card)
        {
            bool test = true;

            for (int i = 0; i < amountOfPlayerCards; i++)
            {
                if (card == playerCards[i])
                {
                    test = false;
                    break;
                }
            }
            return test;
        }
    }
}
