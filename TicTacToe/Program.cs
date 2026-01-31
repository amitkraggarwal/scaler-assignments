// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main(string[] args)
    {           
        Console.WriteLine("Tic Tac Toe Game Started");

        int dimension = 3;
        Console.WriteLine("Tic Tac Toe Game-Board Dimension: " + dimension);

        List<Player> players = new List<Player>();
        players.Add(new Player("Alice", new Symbol('X')));
        players.Add(new Player("Amit", new Symbol('O')));
        GameController gameController = new GameController();
        
        Game game = gameController.StartGame(dimension, players);
        
        Console.WriteLine("Game Status: " + game.GetStatus());
        gameController.printBoard(game);
    }
}
