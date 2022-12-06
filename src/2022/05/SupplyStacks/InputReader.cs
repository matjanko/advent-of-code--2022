namespace SupplyStacks;

public class InputReader
{
    private readonly List<string> _inputs;
    
    public InputReader(List<string> inputs)
    {
        _inputs = inputs;
    }

    public IEnumerable<Stack> ReadStacks()
    {
        return null;
    }
    
    public IEnumerable<CraneMove> ReadCraneMoves()
    {
        int crates, from, to;
        var separator = " ";
        foreach (var input in _inputs)
        {
            if (input.StartsWith("move"))
            {
                crates = int.Parse(input.Split(separator)[1]);
                from = int.Parse(input.Split(separator)[3]);
                to = int.Parse(input.Split(separator)[5]);
                yield return new CraneMove(crates, from, to);
            }
        }
    }
}