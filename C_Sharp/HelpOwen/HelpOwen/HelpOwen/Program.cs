using System;

namespace HelpOwen;

public class Program
{

    public static void Main(string[] args)
    {

        AbilityScoreCalculator scoreCalculator = new AbilityScoreCalculator();

        while (true)
        {
            scoreCalculator.rollResults = ReadInt(scoreCalculator.rollResults, "Starting 4D6 Roll ");
            scoreCalculator.divideBy = ReadDouble(scoreCalculator.divideBy, "Divide By ");
            scoreCalculator.addAmount = ReadInt(scoreCalculator.addAmount, "Add Amount ");
            scoreCalculator.minimum = ReadInt(scoreCalculator.minimum, "Minimum ");

            scoreCalculator.CalculateScore();

            Console.WriteLine("Calculated ability score: " + scoreCalculator.score);
            Console.WriteLine("Press Q to quit, any other key to continue");

            char keychar = Console.ReadKey(true).KeyChar;

            if ((keychar == 'Q') || (keychar == 'q')) return;
        }
    }

    static int ReadInt(int lastUsedValue, string prompt)
    {
        Console.WriteLine(prompt + "["+lastUsedValue+"]: ");

        string valueLine = Console.ReadLine();

        if(int.TryParse(valueLine, out int value))
        {
            Console.WriteLine("     Using Value " + value);
            return value;
        }
        else
        {
            Console.WriteLine("     Using Default Value " + lastUsedValue);
            return lastUsedValue;
        }

    }

    static double ReadDouble(double lastUsedValue, string prompt)
    {
        Console.WriteLine(prompt + "[" + lastUsedValue + "]: ");

        string valueLine = Console.ReadLine();

        if (double.TryParse(valueLine, out double value))
        {
            Console.WriteLine("     Using Value " + value);
            return value;
        }
        else
        {
            Console.WriteLine("     Using Default Value " + lastUsedValue);
            return lastUsedValue;
        }

    }
}