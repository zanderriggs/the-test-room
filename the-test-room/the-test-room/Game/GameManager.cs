using Newtonsoft.Json;
using the_test_room.Assets;
using the_test_room.Configuration;
using the_test_room.Game.Models;
using the_test_room.Output;
using static the_test_room.Configuration.ConfigurationManager;

namespace the_test_room.Game;

class GameManager
{
    public AssetConfiguration AssetConfig {  get; set; }
    public AssetManager AssetManager { get; set; }
    public OutputManager OutputManager { get; set; }
    public GameManager(AssetConfiguration assetConfiguration, AssetManager assetManager, OutputManager outputManager) 
    {
        AssetConfig = assetConfiguration;
        AssetManager = assetManager;
        OutputManager = outputManager;
    }

    /// <summary>
    /// Runs the game and returns when user enters input to quit
    /// </summary>
    public void RunProgram()
    {
        OutputManager outputManger = new();
        var input = "";

        var level = Start();

        var player = new Player();

        while (!input.Equals("q", StringComparison.CurrentCultureIgnoreCase))
        {
            Console.Clear();
            
            // Get and display location description
            var room = level.Locations.FirstOrDefault(x => x.Id.Equals(player.GetLocation()));
            Console.WriteLine($"You are entering the {room.Name}...");

            // Display text from location
            OutputManager.DisplayText(room.Description);
            var locationList = level.Locations.Where(i => room.DestinationIds.Contains(i.Id)).ToList();
            OutputManager.DisplayPlayerOptions(locationList);

            Console.WriteLine("Enter a numbered selection or press \"q\" to quit:");


            // Collect user input
            input = Console.ReadLine();


            // TODO: Turn this into a method somewhere else
            // This is probably two separate methods.
                // One method to parse user input and another to figure out the correct location and move
            if(int.TryParse(input, out var result) == true)
            {
                // Available Room Ids
                var availableLocationIds = room.DestinationIds;
                
                // Determine location to move based on user input
                var locationToMove = level.Locations.FirstOrDefault(x => x.Id == availableLocationIds[result-1]);
                
                // Move to location at result
                player.SetLocation(locationToMove.Id);
                Console.ReadLine();
            }
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
        AssetManager.LoadAssets();

        // Return Level from Asset Manager
        return GetLevel();
    }

    /// <summary>
    /// Runs continuously on user input
    /// </summary>
    public void Update()
    {
        // TODO: Move description reading and user input to this method
    }

    /// <summary>
    /// Retrieves Level from Asset Manager
    /// </summary>
    /// <returns>Level object with list of locations.</returns>
    public Level GetLevel()
    {
        return AssetManager.GetLevels().First();
    }
}
