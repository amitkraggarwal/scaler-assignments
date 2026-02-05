public class Move
{
    private Player player;
    private Cell cell;
    public Move(Player player, Cell cell)
    {
        this.player = player;
        this.cell = cell;   
    }
    public Cell GetCell()
    {
        return this.cell;
    }
    public Player GetPlayer()
    {
        return this.player;
    }

    public void SetPlayer(Player player)
    {
        this.player = player;
    }
}