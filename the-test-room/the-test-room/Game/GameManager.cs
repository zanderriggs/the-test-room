using System.Text.RegularExpressions;

namespace the_test_room.Game;

class GameManager
{
    public GameManager() { }

    /// <summary>
    /// Runs the game and returns when user enters input to quick
    /// </summary>
    public void RunProgram()
    {
        var input = "";

        while (!input.Equals("q", StringComparison.CurrentCultureIgnoreCase))
        {
            Console.Clear();
            // TODO: method to produce output for user
                // Output is made up of Decription and Prompt
            Console.WriteLine("The game has started!");
            Console.WriteLine("Press \"q\" to quit.");

            // Collect user input
            input = GetUserInput();
        }
    }

    /// <summary>
    /// Collects user input and ensures that it's alphanumeric.
    /// </summary>
    /// <returns>Stringified version of user input.</returns>
    static string GetUserInput()
    {
        var input = Console.ReadLine();

        if (IsAlphanumeric(input))
        {

        }

        return input;
    }

    /// <summary>
    /// Checks whether input is alphanumeric.
    /// </summary>
    /// <param name="input"></param>
    /// <returns>Boolean true/false.</returns>
    static bool IsAlphanumeric(string input)
    {
        // Regular expression pattern to match only letters and numbers
        string pattern = "^[a-zA-Z0-9]+$";

        // Check if the input matches the pattern
        return Regex.IsMatch(input, pattern);
    }
}
