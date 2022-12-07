namespace CampCleanup;

internal class SectionAssignmentsConverter
{
    private readonly string _sectionAssignments;
    
    public SectionAssignmentsConverter(string sectionAssignments)
    {
        _sectionAssignments = sectionAssignments;
    }

    public IEnumerable<Section> Convert()
    {
        const string separator = "-";
        foreach (var section in _sectionAssignments.Split(","))
        {
            var from = int.Parse(section.Split(separator)[0]);
            var to = int.Parse(section.Split(separator)[1]);
            yield return new Section(from, to);
        }
    }
}