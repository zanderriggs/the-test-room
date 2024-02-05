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

            Thread.Sleep(40);
        }
    }
}

