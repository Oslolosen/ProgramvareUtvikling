// See https://aka.ms/new-console-template for more information

namespace SomeGuy;

class Program
{
    public static void Main(string[] args)
    {
        Guy joe = new Guy("Joe", 10000);
        Guy bob = new Guy("Bob", 10000);

        string name;

        while (true)
        {
            Console.WriteLine("Who wants to recive money?");
            name = Console.ReadLine();
            
            if(name != "Bob")
            {
                Console.WriteLine("How much money will Bob give to Joe?");
                joe.ReciveCash(bob.GiveCash(Int32.Parse(Console.ReadLine())));
            }
            else
            {
                Console.WriteLine("How much money will Joe give to Bob?");
                bob.ReciveCash(joe.GiveCash(Int32.Parse(Console.ReadLine())));
            }
            joe.ToString();
            bob.ToString();
        }
    }
}
