// Prepare console colors
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.DarkGreen;

Console.Clear();
Console.WriteLine("Hello! Press any key to continue");

Console.ReadKey();

Console.Clear();
Console.WriteLine("Enter your name and press enter");

var userInput = Console.ReadLine();
if (userInput != null)
{
    var name = userInput;
    Console.Clear();
    Console.WriteLine("Welcome to Omega Mainframe, " + name + "!");
}
else
{
    Console.Clear();
    Console.WriteLine("No name entered.");
}


