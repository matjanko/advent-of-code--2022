namespace RucksackReorganization.Domain;

internal class PrioritySpecification
{
    
    private readonly Dictionary<char, int> _lowercaseItemPriority;
    private readonly Dictionary<char, int> _uppercaseItemPriority;
    
    public PrioritySpecification()
    {
        _lowercaseItemPriority = GetItemPriority(ItemsFactory.CreateLowercaseItems(), 1);
        _uppercaseItemPriority = GetItemPriority(ItemsFactory.CreateUppercaseItems(), 27);
    }
    
    public int GetPriority(char item)
    {
        return char.IsLower(item) ? _lowercaseItemPriority[item] : _uppercaseItemPriority[item];
    }

    private Dictionary<char, int> GetItemPriority(List<char> items, int from)
    {
        var dict = new Dictionary<char, int>();
        var value = from;
        foreach (var item in items)
        {
            dict.Add(item, value);
            value++;
        }

        return dict;
    }
}