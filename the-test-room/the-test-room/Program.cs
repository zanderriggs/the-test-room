using the_test_room.Assets;
using the_test_room.Configuration;
using the_test_room.Game;
using the_test_room.Output;

Console.WriteLine("Starting Game...");

// Load configuration
ConfigurationManager configManager = new ConfigurationManager();
configManager.LoadConfig();
AssetManager assetManager = new AssetManager(configManager.AssetConfig);
OutputManager outputManager = new OutputManager();

Console.WriteLine("Configuration loaded...");

// Application logic soon to come
var gameManager = new GameManager(configManager.AssetConfig, assetManager, outputManager);
gameManager.RunProgram();

// For testing:
// Keeps the console window open for review
Console.WriteLine("Press any key to exit...");
Console.ReadKey();