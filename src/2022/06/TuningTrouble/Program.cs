using TuningTrouble;

var input = File.ReadAllLines("../../../Input.txt");
var buffer = input[0];

var chars = buffer.ToCharArray();
var detector = new MarkerDetector();


Console.WriteLine("--- Part One ---");
Console.WriteLine(detector
    .ProcessedCharsBeforeMarkerDetected(
        chars, buffer, 4));



Console.WriteLine("--- Part Two ---");
Console.WriteLine(detector
    .ProcessedCharsBeforeMarkerDetected(
        chars, buffer, 14));
