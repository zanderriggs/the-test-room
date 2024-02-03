using Newtonsoft.Json;
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

        var level = Start();

        while (!input.Equals("q", StringComparison.CurrentCultureIgnoreCase))
        {
            Console.Clear();
            // TODO: method to produce output for user
                // Output is made up of Decription and Prompt
            
            Console.WriteLine("You are entering the first room...");
            var room = level.Locations.FirstOrDefault(x => x.Id.Equals("1"));
            Console.WriteLine($"Room description: {room.Description}");
            Console.WriteLine("Press \"q\" to quit.");

            // Collect user input
            input = Console.ReadLine();
        }
    }

    /// <summary>
    /// Starts game and loads resources.
    /// </summary>
    public Level Start()
    {
        Console.WriteLine("The game has started!");
        Console.WriteLine("Loading game resources...");
        // Load game resources
        return LoadLevel();
    }

    /// <summary>
    /// Runs continuously on user input
    /// </summary>
    public void Update()
    {
        // TODO: Move description reading and user input to this method
    }

    /// <summary>
    /// Loads the level.
    /// </summary>
    /// <returns>Level object with list of locations.</returns>
    public Level LoadLevel()
    {
        // Filepath to asset
        // TODO: Update this to a congif file reference
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
