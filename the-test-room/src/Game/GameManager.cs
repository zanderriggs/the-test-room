namespace the_test_room.Game;

class GameManager
{
    public GameManager() { }

    public void RunProgram()
    {
        var input = "";

        while (!input.Equals("q", StringComparison.CurrentCultureIgnoreCase))
        {
            Console.Clear();
            Console.WriteLine("The game has started!");
            Console.WriteLine("Press \"q\" to quit.");
            input = Console.ReadLine();
        }
    }
}
