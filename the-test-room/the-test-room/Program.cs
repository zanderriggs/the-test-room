using the_test_room.Configuration;
using the_test_room.Game;
using the_test_room.Output;

Console.WriteLine("Starting Game...");

// Load configuration
ConfigurationManager configManager = new ConfigurationManager();
OutputManager outputManager = new OutputManager();
configManager.LoadConfig();
Console.WriteLine("Configuration loaded...");

// Application logic soon to come
var gameManager = new GameManager(configManager.AssetConfig, outputManager);
gameManager.RunProgram();

// For testing:
// Keeps the console window open for review
Console.WriteLine("Press any key to exit...");
Console.ReadKey();