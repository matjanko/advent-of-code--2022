using CathodeRayTube;

var inputs = File.ReadAllLines("../../../Input.txt");
var processor = new Processor();
var cycle = 0;
var signals = new List<int>();
var service = new SignalStrengthService();

foreach (var input in inputs)
{
    int signal;
    if (input.StartsWith("addx"))
    {
        cycle++;
        signal = service.GetSignalStrength(cycle, processor);
        if (signal > 0)
        {
            signals.Add(signal);
        }
        
        var value = int.Parse(input.Split(" ")[1]);
        processor.IncreaseRegister(value);
        cycle++;
        signal = service.GetSignalStrength(cycle, processor);
        if (signal > 0)
        {
            signals.Add(signal);
        }
    }

    if (input == "noop")
    {
        cycle++;
        signal = service.GetSignalStrength(cycle, processor);
        if (signal > 0)
        {
            signals.Add(signal);
        }
    }
}

Console.WriteLine("--- Part One ---");
Console.WriteLine(signals.Sum());


Console.WriteLine("--- Part Two ---");
