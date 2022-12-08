namespace SupplyStacks;

public class CraneMove
{
    public int Crates { get; }
    public int From { get; }
    public int To { get; }

    public CraneMove(int crates, int from, int to)
    {
        Crates = crates;
        From = from;
        To = to;
    }
}