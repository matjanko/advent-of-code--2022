namespace RucksackReorganization.Domain;

internal class RucksacksGroup
{
    private List<Rucksack> _rucksacks = new();

    public void AddRucksack(Rucksack rucksack)
    {
        if (_rucksacks.Count > 3)
        {
            throw new Exception("Too many rucksacks");
        }
        
        _rucksacks.Add(rucksack);
    }
    
    public char GetShareItem()
    {
        var items = _rucksacks.Select(x => x.GetItems()).ToList();
        return items.ElementAt(0).Intersect(items.ElementAt(1).Intersect(items.ElementAt(2))).Single();
    }
}