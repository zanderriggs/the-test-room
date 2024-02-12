using Newtonsoft.Json;
using the_test_room.Game.Models;
using static the_test_room.Configuration.ConfigurationManager;

namespace the_test_room.Assets;

public class AssetManager
{
    AssetConfiguration AssetConfig { get; set; }
    List<Level> Levels{ get; set; }

    public AssetManager(AssetConfiguration assetConfig) 
    {
        AssetConfig = assetConfig;
    }

    public void LoadAssets()
    {
        // Filepath to asset from config
        var jsonFilePath = AssetConfig.LevelData;

        Console.WriteLine($"Loading JSON from filepath: {AssetConfig.LevelData}");

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
                Levels = [];
            }

            Levels = [level];
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An exception occurred while deserializing Json: {ex.Message}");
            Levels = new List<Level>();
        }
    }

    public List<Level> GetLevels()
    {
        return Levels;
    }
}

