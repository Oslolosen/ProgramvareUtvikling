namespace SloppyJoe;

public class Program
{
    public static void Main(string[] args)
    {
        MenuItem menu = new();

        for (int i = 0; i < 10; i++)
        {
            menu.generate();

            Console.WriteLine(menu.toString());
        }     
    }
}
