using System;
namespace SwapElephants;

public class Elephant
{
	public string name;
	public int earSize;

    public void whoAmI()
    {
        Console.WriteLine("\nMy name is: "+ name);
        Console.WriteLine("My ears are " + earSize + " inches");
    }
    public void HearMessage(string message, Elephant whoSaidIt)
    {
        Console.WriteLine("\n"+name + " heard a message ");
        Console.WriteLine(whoSaidIt.name + " said this: " + message);
    }

    public void speakTo(Elephant whoTalkTo, string message)
    {
        whoTalkTo.HearMessage(message, this);
    }
}
