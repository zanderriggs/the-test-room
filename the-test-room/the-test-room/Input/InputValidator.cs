using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace the_test_room.Input;

public class InputValidator
{
    /// <summary>
    /// Validates the users input.
    /// </summary>
    /// <param name="command"></param>
    /// <returns>Boolean of input validity.</returns>
    public static bool IsValidCommand(string command)
    {
        // Validate input is not empty
        return !string.IsNullOrWhiteSpace(command);

        // TODO: Validate that input is expected character type
        // Use IsAlphanumeric
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

