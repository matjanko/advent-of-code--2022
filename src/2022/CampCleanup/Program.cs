using CampCleanup;

var inputs = File.ReadAllLines("../../../Input.txt");
var pairs = inputs.Select(input => new ElvesPair(new SectionAssignmentsConverter(input))).ToList();

var fullyContainRanges = pairs.Where(x => x.HasFullyOverlap()).ToList();
var result = fullyContainRanges.Count;

Console.WriteLine("--- Part One ---");
Console.WriteLine(result);

var partialContainRanges = pairs.Where(x => x.HasPartialOverlap()).ToList();
result = partialContainRanges.Count;

Console.WriteLine("--- Part Two ---");
Console.WriteLine(result);