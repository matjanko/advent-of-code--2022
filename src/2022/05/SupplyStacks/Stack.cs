namespace SupplyStacks;

public class Stack
{
    private List<char> _crates;
    
    public int Id { get; }

    public Stack(int id, List<char> crates)
    {
        Id = id;
        _crates = crates;
    }

    public char GetTopCrate()
    {
        return _crates[0];
    }

    public IEnumerable<char> RemoveCratesFromTop(int quantity)
    {
        var cratesToMove = _crates.GetRange(0, quantity);
        _crates.RemoveRange(0, quantity);
        return cratesToMove;
    }

    public void AddCratesOnTop(IEnumerable<char> crates)
    {
        var tempCrates = _crates;
        _crates = new List<char>();
        _crates.AddRange(crates);
        _crates.AddRange(tempCrates);
    }
}