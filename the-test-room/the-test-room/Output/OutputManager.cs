using the_test_room.Game.Models;

namespace the_test_room.Output;

public class OutputManager
{
    /// <summary>
    /// Displays text message-- Either description from level location or text from dialogue tree.
    /// </summary>
    /// <param name="message"></param>
    public static void DisplayText(string message)
    {
        PrintTextSlowly(message);
    }

    /// <summary>
    /// Prints text as though it is being typed.
    /// </summary>
    /// <param name="message"></param>
    private static void PrintTextSlowly(string message)
    {
        foreach (char c in message)
        {
            Console.Write(c);

            Thread.Sleep(15);
        }
        Console.WriteLine();
    }

    /// <summary>
    /// Prints locations as numbered selections for the player to select by entering the number.
    /// </summary>
    /// <param name="locations"></param>
    public static void DisplayPlayerOptions(List<Location> locations)
    {
        var number = 1;

        foreach (var location in locations)
        {
            Console.WriteLine($"{number}. {location.Name}");
            number++;
        }

    }
}

