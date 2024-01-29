namespace the_test_room.Output;

public class OutputManager
{
    /// <summary>
    /// Displays message. Either description from level location or text from dialogue tree.
    /// </summary>
    /// <param name="message"></param>
    public static void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }
}

