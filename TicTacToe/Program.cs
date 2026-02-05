// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main(string[] args)
    {           
        Console.WriteLine("Tic Tac Toe Game Started");

        int dimension = 3;
        Console.WriteLine("Tic Tac Toe Game-Board Dimension: " + dimension);

        List<Player> players = new List<Player>();
        players.Add(new Player("Anjana", new Symbol('X')));
        players.Add(new Player("Amit", new Symbol('O')));
       // players.Add(new Bot("Bot1", new Symbol('O'),BotDifficultyLevel.EASY)) ;

        List<WinningStrategy> winningStrategies = new List<WinningStrategy>();
        winningStrategies.Add( new RowWinningStrategy());
        winningStrategies.Add( new ColumnWinningStrategy());

        GameController gameController = new GameController();
        

        Game game = gameController.StartGame(dimension, players, winningStrategies);
        
        Console.WriteLine("Game Status: " + game.GetStatus());
        //gameController.printBoard(game);

        while (game.GetStatus() == GameStatus.IN_PROGRESS)
        {
            // Game loop logic would go here
           gameController.printBoard(game);
           gameController.makeMove(game); // Placeholder for actual move-making logic
            
        }  
        gameController.printBoard(game);
         if(game.GetStatus() == GameStatus.WIN)
         {
            if(game.getWinner() != null)
            {
            
                {
                Console.WriteLine("Winner is: " + game.getWinner().GetName());
                }
            }
         }
         else if (game.GetStatus() == GameStatus.DRAW)
            {
                Console.WriteLine("The game ended in a draw.");
            }
         
    }
}
