namespace SupplyStacks;

internal class Ship
{
    private readonly List<Stack> _stacks;
    
    public Ship(List<Stack> stacks)
    {
        _stacks = stacks;
    }

    public void MoveCratesBetweenStacks(CraneMove move, bool reverse)
    {
        var stackFrom = _stacks.ElementAt(move.From - 1);
        var stackTo = _stacks.ElementAt(move.To - 1);
        var cratesToMove = stackFrom.RemoveCratesFromTop(move.Crates).ToList();
        
        if (reverse)
        {
            cratesToMove.Reverse();
        }
        
        stackTo.AddCratesOnTop(cratesToMove);
    }

    public IEnumerable<char> GetTopCrates()
    {
        return _stacks.Select(x => x.GetTopCrate());
    }
}