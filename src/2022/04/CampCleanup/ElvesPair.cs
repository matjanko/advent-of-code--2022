namespace CampCleanup;

internal class ElvesPair
{
    private readonly Section _sectionA;
    private readonly Section _sectionB;

    public ElvesPair(SectionAssignmentsConverter converter)
    {
        var sections = converter.Convert().ToList();
        _sectionA = sections.First();
        _sectionB = sections.Last();
    }

    public bool HasFullyOverlap()
    {
        return (_sectionA.From <= _sectionB.From && _sectionA.To >= _sectionB.To) ||
               (_sectionA.From >= _sectionB.From && _sectionA.To <= _sectionB.To);
    }

    public bool HasPartialOverlap()
    {
        return _sectionA.Numbers.Any(x => _sectionB.Numbers.Contains(x));
    }
}