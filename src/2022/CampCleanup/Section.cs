namespace CampCleanup;

internal class Section
{
    public int From { get; }
    public int To { get; }
    public List<int> Numbers { get; }

    public Section(int from, int to)
    {
        From = from;
        To = to;
        Numbers = Enumerable.Range(from, to - from + 1).ToList();
    }
}