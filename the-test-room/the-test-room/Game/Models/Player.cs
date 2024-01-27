namespace the_test_room.Game.Models;

public class Player
{
    public string Name { get; set; }
    public int Insight { get; set; }
    public int Prowess { get; set; }
    public int Resolve {  get; set; }
    public List<string> Inventory { get; set; } = new List<string>();

    public Player()
    {
            
    }

    // Inventory Maangement
    public void AddItemToInventory(string item)
    {
        Inventory.Add(item);
    }

    public void RemoveItemFromInventory(string item) 
    {  
        Inventory.Remove(item);
    }

    /// <summary>
    /// Returns inventory items as a comma separated list for printing in sentences
    /// </summary>
    public string GetInventoryItemsAsSentence()
    {
        return "";
    }

    // Ability Score Management
    // This is for levelling up
    public void AddPointToInsight()
    {
        Insight++;
    }

    public void AddPointToProwess()
    {
        Prowess++;
    }

    public void AddPointToresolve()
    {
        Resolve++;
    }
}
