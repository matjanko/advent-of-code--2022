namespace RucksackReorganization.Domain;

internal class Rucksack
{
    private readonly Compartment _firstCompartment;
    private readonly Compartment _secondCompartment;
    public Rucksack(List<char> items)
    {
        _firstCompartment = new Compartment(ItemsSplitter.FirstHalf(items));
        _secondCompartment = new Compartment(ItemsSplitter.SecondHalf(items));

    }

    public char GetShareItem()
    {
        return _firstCompartment.Items.Intersect(_secondCompartment.Items).Single();
    }

    public List<char> GetItems()
    {
        var items = new List<char>();
        items.AddRange(_firstCompartment.Items);
        items.AddRange(_secondCompartment.Items);
        return items;
    }
}