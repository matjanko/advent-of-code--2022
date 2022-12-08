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
        var inputs = _inputs.Where(x => x.Contains('[') && x.Contains(']')).ToList();
        var stackNo = inputs.Select(x => x.Split("] [")).Max(x => x.Length);
        var position = 1;
        for (var i = 0; i < stackNo; i++)
        {
            var id = i + 1;
            var crates = inputs.Select(input => input[position]).Where(crate => crate != ' ').ToList();
            position += 4;
            yield return new Stack(id, crates);
        }
    }
    
    public IEnumerable<CraneMove> ReadCraneMoves()
    {
        const string separator = " ";
        foreach (var input in _inputs)
        {
            if (!input.StartsWith("move"))
            {
                continue;
            }
            
            var crates = int.Parse(input.Split(separator)[1]);
            var from = int.Parse(input.Split(separator)[3]);
            var to = int.Parse(input.Split(separator)[5]);
            yield return new CraneMove(crates, from, to);
        }
    }
}