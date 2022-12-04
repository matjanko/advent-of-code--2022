namespace RucksackReorganization.Domain;

internal class Compartment
{
    public List<char> Items { get; }

    public Compartment(List<char> items)
    {
        Items = items;
    }
}