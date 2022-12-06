namespace SupplyStacks;

public class Stack
{
    private List<char> _crates = new();
    
    public int Id { get; }

    public Stack(int id)
    {
        Id = id;
    }
    
    
}