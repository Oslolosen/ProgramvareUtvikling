// See https://aka.ms/new-console-template for more information

namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            MyFirstCSharpProgram myFirstCSharpProgram = new MyFirstCSharpProgram();

            Console.WriteLine("Gi meg ett ord");

            string input = Console.ReadLine();

            myFirstCSharpProgram.HelloWorld(input);
        }
    }
}