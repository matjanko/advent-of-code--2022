namespace RucksackReorganization.Domain;

internal class ItemsSplitter
{
    public static List<char> FirstHalf(List<char> items)
    {
        return items.Take(items.Count / 2).ToList();
    }

    public static List<char> SecondHalf(List<char> items)
    {
        var half = items.Count / 2;
        return items.Skip(half).Take(half).ToList();
    }
}