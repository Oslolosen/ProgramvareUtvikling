// See https://aka.ms/new-console-template for more information

namespace SwapElephants;

public class Program{
       
    public static void Main(string[] args)
    {
        Elephant lucida = new Elephant() { name = "Lucida", earSize = 33 };
        Elephant lloyd = new Elephant() { name = "Lloyd", earSize = 40 };

        while (true)
        {
            Console.WriteLine("\nPress 1 for " + lucida.name + " Press 2 for " + lloyd.name + " Press 3 for swap" + " Press 4 for speak");
            char press = Console.ReadKey().KeyChar;
        
            if(press == '1')
            {
                lucida.whoAmI();
            }
            else if(press == '2')
            {
                lloyd.whoAmI();
            }
            else if(press == '3')
            {
                Elephant tmp;
                tmp = lucida;
                lucida = lloyd;
                lloyd = tmp;
                Console.WriteLine("\nElephants have been swaped");
            }
            else if(press == '4')
            {
                lucida.speakTo(lloyd, "Hey, Lloyd");
            }
            else
            {
                Console.WriteLine("\nInvalid Choice");
            }
        }
    }   
}
