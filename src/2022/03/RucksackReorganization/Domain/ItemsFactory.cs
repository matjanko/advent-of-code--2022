namespace RucksackReorganization.Domain;

internal class ItemsFactory
{
    private const string Alphabet = "abcdefghijklmnopqrstuvwxyz";

    public static List<char> CreateLowercaseItems()
    {
        return Alphabet.Select(x => x).ToList();
    }

    public static List<char> CreateUppercaseItems()
    {
        return Alphabet.ToUpper().Select(x => x).ToList();
    }
}