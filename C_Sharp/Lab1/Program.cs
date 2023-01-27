// See https://aka.ms/new-console-template for more information

namespace Lab1
{
    class Program
    {
        public static void Main(string[] args)
        {

            BlackJack blackJack = new BlackJack();

            string playOrNot;

            while (true)
            {
                Console.WriteLine("Do you want to play? y/n");
                playOrNot = Console.ReadLine();

                if (playOrNot == "y")
                {
                    blackJack.playBlackJack();
                    blackJack.resetBlackJack();
                }
                else
                {
                    break;
                }
            }
        }
    }
}