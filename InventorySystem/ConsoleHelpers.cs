public static class ConsoleHelpers
{
    /// <summary>
    /// Asks user for a name until a valid name is entered.
    /// </summary>
    public static void EnterNameLoop()
    {
        Console.Clear();
        Console.WriteLine("Enter your name and press enter");

        var userInput = Console.ReadLine();

        if (userInput == null || userInput == string.Empty)
        {
            Console.Clear();
            Console.WriteLine("No name entered. Press any key to try again...");
            Console.ReadKey();
            EnterNameLoop();
        }
        else
        {
            var name = userInput;
            Console.Clear();
            Console.WriteLine("Welcome to Omega Mainframe, " + name + "!");
        }
    }
}

