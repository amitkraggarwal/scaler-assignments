public class EasyLevelStrategy : BotPlayingStrategy
{
 
    public Move DecideMove(Board board)
    {
        List<Cell> emptyCells = board.GetEmptyCells();
        Random random = new Random();
        int index = random.Next(emptyCells.Count);
        Cell selectedCell = emptyCells[index];
        return new Move(null, selectedCell);
    }
}