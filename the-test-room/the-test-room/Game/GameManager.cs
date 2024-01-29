﻿using Newtonsoft.Json;
using System.Text.RegularExpressions;
using the_test_room.Game.Models;
using System.Linq;
using System.Data;

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
            Console.WriteLine("You are entering the first room...");
            var level = LoadLevel();
            var room = level.Locations.FirstOrDefault(x => x.Id.Equals("1"));
            Console.WriteLine($"Room description: {room.Description}");
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

    /// <summary>
    /// Loads the level.
    /// </summary>
    /// <returns>Level object with list of locations.</returns>
    public Level LoadLevel()
    {
        // Filepath to asset
        var jsonFilePath = "C:\\git\\the-test-room\\The-Test-Room\\the-test-room\\Assets\\Hotel.json";
        
        // Read JSONfile at filepath
        var jsonContent = File.ReadAllText(jsonFilePath);
        var level = new Level();

        try
        {
            // Deserialize JSON
            level = JsonConvert.DeserializeObject<Level>(jsonContent);

            if (level == null)
            {
                Console.WriteLine("Location data not found");
                return new Level();
            }
            return level;
        }
        catch (Exception ex) 
        {
            Console.WriteLine($"An exception occurred while deserializing Json: {ex.Message}");
            return new Level();
        }
    }
}
