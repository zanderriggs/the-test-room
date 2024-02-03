using System.Text.Json;

namespace the_test_room.Configuration;

public class ConfigurationManager
{
    public AssetConfiguration AssetConfig { get; set; }

    public void LoadConfig()
    {
        Console.WriteLine("Loading configuration...");

        // Read config file at path
        string json = File.ReadAllText("config.json");

        // Deserialize JSON into configuration
        ConfigObject config = JsonSerializer.Deserialize<ConfigObject>(json);

        AssetConfig = config.Assets;
    }

    private class ConfigObject
    {
        public required AssetConfiguration Assets { get; set; }
    }

    public class AssetConfiguration
    {
        public required string LevelData { get; set; }
    }
}
